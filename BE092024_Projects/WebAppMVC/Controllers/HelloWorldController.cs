using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers;

public class HelloWorldController : Controller
{
    // GET
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }

    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int numtimes = 1)
    {
        ViewData["Message"] = $"Hello, {name}!";
        ViewData["Numtimes"] = numtimes;
        return View();
    }
}