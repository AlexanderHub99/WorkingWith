using Microsoft.AspNetCore.Mvc;
using WorkingWith.Models;

namespace WorkingWith;

public class HomeController : Controller
{
    public IActionResult Index() => View(SimpleRepository.ShardRepositiry.Products);
}