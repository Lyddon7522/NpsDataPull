using Microsoft.Extensions.Configuration;
using NpsDataPull.Application;
using NpsDataPull.Domain.Models;

namespace NpsDataPull.Infrastructure.Services;

public class NpsParkService(IConfiguration configuration) : INpsParkService
{
    private readonly IConfiguration _configuration = configuration;
    
    public Task<IEnumerable<NpsParksApi>> GetParksAsync()
    {
        throw new NotImplementedException();
    }
}