namespace MediFlow.Backend.Api.Models;

public class Address
{
    public required string AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public string? ZipCode { get; set; }
    public string? Country { get; set; }
}