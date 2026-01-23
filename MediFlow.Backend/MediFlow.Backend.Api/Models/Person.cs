namespace MediFlow.Backend.Api.Models;

public abstract class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Email { get; set; }
    public required string PhoneNumber { get; set; }
    public Address? Address { get; set; }
}