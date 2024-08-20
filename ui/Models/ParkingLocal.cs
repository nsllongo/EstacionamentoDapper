namespace estacionamento.Models;

public class ParkingLocal
{
    public int Id { get; set; } = default!;
    public string Local { get; set; } = default!;
    public bool IsAvailable { get; set; } = default!;
    public int VehicleId { get; set; } = default!;
}