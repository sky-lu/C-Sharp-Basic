using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View("samplePost");
        }

        public IActionResult List()
        {
            return View("List");
        }
        
        public IActionResult Add()
        {
            return View("Add");
        }
    }
}