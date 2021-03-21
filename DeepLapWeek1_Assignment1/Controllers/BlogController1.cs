using DeepLapWeek1_Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepLapWeek1_Assignment1.Controllers
{
    public class BlogController1 : Controller
    {
        public IActionResult Index()
        {
            return View(Tuple.Create<BlogDetay, BlogYazar>(new BlogDetay(), new BlogYazar()));
            
        }
    }
}
