using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel dog = new DogViewModel() 
            { 
                Name = "Fippy", 
                Age = 2 
            };
            return View(dog);
        }


        public IActionResult Create()
        {
            return View();
        }
    }
}
