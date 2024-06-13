using Microsoft.AspNetCore.Mvc;
using MohaliProperty.Web.Models;
using System.Diagnostics;

namespace MohaliProperty.Web.Controllers
{
    public class HomeController : Controller { 
    //{
    //    private readonly ApplicationDbContext _context;
    //    public HomeController(ApplicationDbContext context)
    //    {
    //        _context = context;
    //    }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult ProjectPage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}