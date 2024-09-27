namespace NpsDataPull.Domain.Models;

public class NationalPark
{
    public List<Activities>? Activities { get; set; }
    public List<Addresses>? Addresses { get; set; }
    public List<Contacts>? Contacts { get; set; }
    public string? Description { get; set; }
    public string? Designation { get; set; }
    public string? DirectionsInfo { get; set; }
    public string? DirectionsUrl { get; set; }
    public List<EntranceFees>? EntranceFees { get; set; }
    public List<EntrancePasses>? EntrancePasses { get; set; }
    public string? FullName { get; set; }
    public string? Id { get; set; }
    public List<Images>? Images { get; set; }
    public string? LatLong { get; set; }
    public List<Multimedia>? Multimedia { get; set; }
    public string? Name { get; set; }
    public List<OperatingHours>? OperatingHours { get; set; }
    public string? ParkCode { get; set; }
    public int? RelevanceScore { get; set; }
    public string? States { get; set; }
    public List<Topics>? Topics { get; set; }
    public string? Url { get; set; }
    public string? WeatherInfo { get; set; }
}