using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        //persist a single dogs list; doesnt need an instance of the controller
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            DogViewModel dogViewModel = new DogViewModel();
            return View(dogViewModel); //data binding - Controller > View
        }

        public IActionResult CreateDog(DogViewModel newDog)
        {
            dogs.Add(newDog);
            return RedirectToAction(nameof(Index));
        }


    }
}
