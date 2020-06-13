using Microsoft.AspNetCore.Mvc;
using Portfolio_Website.Models;

namespace Portfolio_Website.Controllers
{
    public class HomeController : Controller
    {
        private Portfolio _Portfolio { get; set; }

        public HomeController(Portfolio Portfolio_)
        {
            _Portfolio = Portfolio_;
        }

        public IActionResult Index()
        {
            return View(_Portfolio);
        }


    }
}
