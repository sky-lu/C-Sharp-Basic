using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Blog.Controllers
{
    public class SigninController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        //public Boolean test()
        //{
        //    string myConnectionString = "Database=blog_db;Data Source=localhost;User Id=root;Password=";
        //    MySqlConnection myConnection = new MySqlConnection(myConnectionString);
        //    string myInsertQuery = "INSERT INTO users (id, email, password) Values(12, 'xuming@gmail.com', 'lalllalalal')";
        //    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
        //    myCommand.Connection = myConnection;
        //    myConnection.Open();
        //    myCommand.ExecuteNonQuery();
        //    myCommand.Connection.Close();
        //    System.Console.WriteLine("hello world");
        //    return true;
        //}
    }
}