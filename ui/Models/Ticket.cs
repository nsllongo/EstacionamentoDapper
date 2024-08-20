namespace estacionamento.Models;

public class Ticket
{
    public int Id { get; set; } = default!;
    public DateTime InDate { get; set; } = default!;
    public DateTime OutDate { get; set; } = default!;
    public int VehicleId { get; set; } = default!;
}