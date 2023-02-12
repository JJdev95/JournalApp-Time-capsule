using System.Reflection;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using TimeCapsule.Domain.Entities;

namespace TimeCapsule.Infrastructure.Data.SeedData
{
    public class TimeCapsuleDbContextSeed
    {
        public static async Task SeedAsync(TimeCapsuleDbContext context, ILoggerFactory loggerFactory)
        {
            var logger = loggerFactory.CreateLogger<TimeCapsuleDbContextSeed>();
            try
            {
                logger.LogDebug("starting seeding data...");
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                if (!context.JournalTypes.Any())
                {
                    var journalTypesData = File.ReadAllText(path + @"/Data/SeedData/JournalTypes.json");
                    var journalTypes = JsonSerializer.Deserialize<List<JournalType>>(journalTypesData);

                    if (journalTypes is not null)
                    {
                        foreach (var item in journalTypes)
                        {
                            context.JournalTypes.Add(item);
                        }
                    }


                    await context.SaveChangesAsync();
                }

                if (!context.JournalEntries.Any())
                {
                    var journalEntriesData = File.ReadAllText(path + @"/Data/SeedData/JournalEntries.json");
                    var journalEntries = JsonSerializer.Deserialize<List<JournalEntry>>(journalEntriesData);

                    if (journalEntries is not null)
                    {
                        foreach (var item in journalEntries)
                        {
                            item.EntryDate = item.EntryDate.ToUniversalTime();
                            context.JournalEntries.Add(item);
                        }
                    }


                    await context.SaveChangesAsync();
                }

                logger.LogDebug("seed successfull");

            }
            catch (Exception ex)
            {

                logger.LogError(ex.Message);
            }
        }
    }
}

