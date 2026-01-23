using MediFlow.Backend.Api.Models.Enums;

namespace MediFlow.Backend.Api.Models;

public class Patient : Person
{
    public DateOnly BirthDate { get; set; }
    public BiologicalSex BiologicalSex { get; set; }
    public required string EmergencyContactNumber { get; set; }
}