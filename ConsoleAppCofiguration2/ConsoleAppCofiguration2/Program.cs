using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

// https://www.tektutorialshub.com/entity-framework-core/ef-core-database-connection-string/

var builder = new ConfigurationBuilder();
builder.AddJsonFile("appsettings.json", optional: false);

var configuration = builder.Build();

var connectionString = configuration.GetConnectionString("DefaultConnection");

Console.WriteLine(connectionString);
Console.ReadKey();