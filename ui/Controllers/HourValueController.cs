using System.Data;
using Dapper;
using estacionamento.Models;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.X509;

namespace estacionamento.Controllers;

[Route("/values")]

public class HourValueController : Controller
{
    private readonly IDbConnection _connection;

    public HourValueController(IDbConnection connection)
    {
        _connection = connection;
        
    }
    
    
    public IActionResult Index()
    {
        var hourValues = _connection.Query<HourValue>("SELECT * FROM VALUE");
        return View(hourValues);
    }
    
    [HttpGet("/add")]
    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost("/add")]
    public IActionResult Add([FromForm]HourValue hourValue)
    {
        _connection.Execute("INSERT INTO VALUE (Name, Value_Hour) VALUES (@Name, @Value_Hour)", hourValue);
        return RedirectToAction("Index");
    }

    //Como não estou usando API, usarei o post para deletar o valor do BD
    [HttpPost("/{id}/delete")]
    public IActionResult Delete([FromRoute] int id)
    {
        _connection.Execute("DELETE FROM VALUE WHERE Id = @Id", new {Id = id});
        return Redirect("/values");
    }
}    