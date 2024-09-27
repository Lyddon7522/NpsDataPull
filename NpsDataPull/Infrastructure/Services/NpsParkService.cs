using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using NpsDataPull.Application;
using NpsDataPull.Domain.Models;
using Newtonsoft.Json;

namespace NpsDataPull.Infrastructure.Services;

public class NpsParkService(IConfiguration configuration, HttpClient httpClient) : INpsParkService
{
    private readonly IConfiguration _configuration = configuration;
    private readonly HttpClient _httpClient = httpClient;
    
    public async Task<NpsParksApi?> GetParksAsync()
    {
        var npsParkApiUrl = $"{_configuration["ApiSettings:BaseUrl"]}/parks";
        
        var response = await httpClient.GetStringAsync(npsParkApiUrl);
        var parks = JsonConvert.DeserializeObject<NpsParksApi>(response);
        return parks;

    }
}