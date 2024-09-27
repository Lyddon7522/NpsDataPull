using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NpsDataPull.Application;
using NpsDataPull.Infrastructure;
using NpsDataPull.Infrastructure.Services;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton(configuration);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

var apiKey = configuration["ApiSettings:ApiKey"];
using HttpClient httpClient = new();
httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);

builder.Services.AddSingleton<INpsParkService>(
    sp => new NpsParkService(sp.GetRequiredService<IConfiguration>(), httpClient));

var host = builder.Build();

using var scope = host.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    var npsParkService = services.GetRequiredService<INpsParkService>();
    var parks = await npsParkService.GetParksAsync();
    // Use the parks data here
    Console.WriteLine($"Total Parks: {parks?.Total}");
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred while getting parks data.");
    Console.WriteLine(ex.Message);
}

await host.RunAsync();



