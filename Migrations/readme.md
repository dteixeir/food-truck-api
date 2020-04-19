dotnet ef database update 0
dotnet ef migrations remove

dotnet ef migrations add Init
dotnet ef database update
dotnet ef migrations add SeedData1
dotnet ef database update