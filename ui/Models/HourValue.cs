using System.Text.RegularExpressions;

namespace estacionamento.Models;

public class HourValue
{
    public int Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public decimal Value_Hour { get; set; } = default!;
    
    public string[] splitName =>  Regex.Split(Name, @"(?<!^)(?=[A-Z])");

}


