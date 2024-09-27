using System.Collections.Generic;
using System.Threading.Tasks;
using NpsDataPull.Domain.Models;

namespace NpsDataPull.Application;

public interface INpsParkService
{
    Task<NpsParksApi?> GetParksAsync();
}