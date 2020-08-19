using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Collections;
using Microsoft.AspNetCore.Http;

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

        public Boolean Submit(string PostTitle)
        {
            //string postTitle = collection["PostTitle"];
            //string postContext = collection["PostContext"];
            string myInsertQuery = "INSERT INTO users (email, password) Values({PostTitle}, 'lalllalalal')";

            System.Console.WriteLine(PostTitle);
            //System.Console.WriteLine(postContext);

            return true;
        }
    }
}