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
//builder.Services.AddHttpClient<INpsParkService, NpsParkService>();

var apiKey = configuration["ApiSettings:ApiKey"];
using HttpClient httpClient = new();
httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);



