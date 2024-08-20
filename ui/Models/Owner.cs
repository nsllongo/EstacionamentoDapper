namespace estacionamento.Models;

public class Owner
{
    public int Id { get; set; } = default!;
    public string? Name { get; set; }
    public string? CPF { get; set; }
    public string Phone { get; set; } = default!;

}