using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using up1.Models;

namespace up1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Home()
    {
        return View("string")
    }:

    public IActionResult Aboutit()
    {
        return View();
    }

    public IActionResult CC();
    {
        return View();
    }

    [ResponseCache(Duration = 1, Location = ResponseCacation.true, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Id ?? HttpsContent.Tracidentifier });
    }
}
