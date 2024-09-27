namespace NpsDataPull.Domain.Models;

public class NpsParksApi
{
    public string? Total { get; set; }
    public List<Park>? Data { get; set; }
    public string? Limit { get; set; }
    public string? Start { get; set; }
}

public class Park
{
    public List<Activities>? Activities { get; set; }
    public List<Addresses>? Addresses { get; set; }
    public Contacts? Contacts { get; set; }
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
    public double? RelevanceScore { get; set; }
    public string? States { get; set; }
    public List<Topics>? Topics { get; set; }
    public string? Url { get; set; }
    public string? WeatherInfo { get; set; }
}

public class Activities
{
    public string? Id { get; set; }
    public string? Name { get; set; }
}

public class Addresses
{
    public string? Line1 { get; set; }
    public string? Line2 { get; set; }
    public string? Line3 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? CountryCode { get; set; }
    public string? ProvinceTerritoryCode { get; set; }
    public string? PostalCode { get; set; }
    public string? Type { get; set; }
}

public class Contacts
{
    public List<PhoneNumbers>? PhoneNumbers { get; set; }
    public List<EmailAddresses>? EmailAddresses { get; set; }
}

public class PhoneNumbers
{
    public string? PhoneNumber { get; set; }
    public string? Description { get; set; }
    public string? Extension { get; set; }
    public string? Type { get; set; }
}

public class EmailAddresses
{
    public string? EmailAddress { get; set; }
    public string? Description { get; set; }
}

public class EntranceFees
{
    public string? Cost { get; set; }
    public string? Description { get; set; }
    public string? Title { get; set; }
}

public class EntrancePasses
{
    public string? Cost { get; set; }
    public string? Description { get; set; }
    public string? Title { get; set; }
}

public class Images
{
    public string? Credit { get; set; }
    public string? AltText { get; set; }
    public string? Title { get; set; }
    public int Id { get; set; }
    public string? Caption { get; set; }
    public string? Url { get; set; }
}

public class Multimedia
{
    public string? Title { get; set; }
    public string? Id { get; set; }
    public string? Type { get; set; }
    public string? Url { get; set; }
}

public class OperatingHours
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public StandardHours? StandardHours { get; set; }
    public List<Exceptions>? Exceptions { get; set; }
}

public class StandardHours
{
    public string? Sunday { get; set; }
    public string? Monday { get; set; }
    public string? Tuesday { get; set; }
    public string? Wednesday { get; set; }
    public string? Thursday { get; set; }
    public string? Friday { get; set; }
    public string? Saturday { get; set; }
}

public class Exceptions
{
    public string? Name { get; set; }
    public string? StartDate { get; set; }
    public string? EndDate { get; set; }
    public ExceptionHours? ExceptionHours { get; set; }
}

public class ExceptionHours
{
    public string? Sunday { get; set; }
    public string? Monday { get; set; }
    public string? Tuesday { get; set; }
    public string? Wednesday { get; set; }
    public string? Thursday { get; set; }
    public string? Friday { get; set; }
    public string? Saturday { get; set; }
}

public class Topics
{
    public string? Id { get; set; }
    public string? Name { get; set; }
}

