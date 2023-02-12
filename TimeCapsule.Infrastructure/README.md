## Infrastructure README

This is the infrastructure later of the project.

## Migrations

For adding migrations use the following script: 

dotnet ef migrations add <name> -c TimeCapsuleDbContext  -p TimeCapsule.Infrastructure.csproj -s ..\TimeCapsule.API\TimeCapsule.API.csproj -o Data\Migrations. 

Make sure to change the <name> to the desired name of the migration. The migrations will be applied in Data\Migrations folder.

