namespace estacionamento.Models;

public class Vehicle
{
    public int Id { get; set; } = default!;
    public string Make { get; set; } = default!;
    public string Model { get; set; } = default!;
    public string LicensePlate { get; set; } = default!;
    public int OwnerId { get; set; } = default!;

}