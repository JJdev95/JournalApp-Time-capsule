using Microsoft.EntityFrameworkCore;
using TimeCapsule.Infrastructure.Data;
using TimeCapsule.Infrastructure.Data.SeedData;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = new ConfigurationBuilder()
.AddJsonFile("appsettings.json").Build();

builder.Services.AddDbContext<TimeCapsuleDbContext>(options =>
    options.UseNpgsql(configuration.GetConnectionString("TimeCapsuleDbContext")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

var provideServices = builder.Services.BuildServiceProvider();

var loggerFactory = provideServices.GetRequiredService<ILoggerFactory>();

try
{
    var context = provideServices.GetRequiredService<TimeCapsuleDbContext>();

    //investigate how to do this properly, it throws an error if db exists.
    //await context.Database.MigrateAsync();
    
    await TimeCapsuleDbContextSeed.SeedAsync(context, loggerFactory);
}
catch (Exception ex)
{

}


app.Run();
