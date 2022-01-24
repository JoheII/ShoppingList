using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShoppingList.Models;

namespace ShoppingList.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ShoppingListContext _context;

    public HomeController(ILogger<HomeController> logger, ShoppingListContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Shoppinglist()
    {
        var myData = _context.BuyLists.ToList();
        return View(new ShoppingListActive{ 
            BuyListData = myData
        });
    }

        public IActionResult Buylist()
    {
        var myData = _context.BuyLists.ToList();
        return View(new ShoppingListActive{ 
            BuyListData = myData
        });
    }

    public IActionResult Meals()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
