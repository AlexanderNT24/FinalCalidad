using System.Diagnostics;
using Calidad20222.web.Helper;
using Microsoft.AspNetCore.Mvc;
using Calidad20222.web.Models;
using Calidad20222.web.Services;

namespace Calidad20222.web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new List<Carta>());
    }
    
    [HttpPost]
    public IActionResult Generar()
    {
        var Carta1=new Carta();
        Carta1.Numero = int.Parse(Request.Form["carta1"]);
        Carta1.Palo = Request.Form["carta1Palo"];
        var Carta2 = new Carta();
        Carta2.Numero = int.Parse(Request.Form["carta2"]);
        Carta2.Palo = Request.Form["carta2Palo"];

        var Carta3 = new Carta();
        Carta3.Numero = int.Parse(Request.Form["carta3"]);
        Carta3.Palo = Request.Form["carta3Palo"];

        var Carta4 = new Carta();
        Carta4.Numero = int.Parse(Request.Form["carta4"]);
        Carta4.Palo = Request.Form["carta4Palo"];

        var Carta5 = new Carta();
        Carta5.Numero = int.Parse(Request.Form["carta5"]);
        Carta5.Palo = Request.Form["carta5Palo"];

        List<Carta> cartas = new List<Carta>();
        cartas.Add(Carta1);
        cartas.Add(Carta2);
        cartas.Add(Carta3);
        cartas.Add(Carta4);
        cartas.Add(Carta5);

        Debug.WriteLine("carta1->" + Carta1.Numero + " "+ Carta1.Palo);
        Debug.WriteLine("carta2->" + Carta2.Numero + " " + Carta2.Palo);
        Debug.WriteLine("carta3->" + Carta3.Numero + " " + Carta3.Palo);
        Debug.WriteLine("carta4->" + Carta4.Numero + " " + Carta4.Palo);
        Debug.WriteLine("carta5->" + Carta5.Numero + " " + Carta5.Palo);


        var service = new PokerService();

        ViewBag.Jugada = service.GetJugada(cartas);
        return View("Index", cartas);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}