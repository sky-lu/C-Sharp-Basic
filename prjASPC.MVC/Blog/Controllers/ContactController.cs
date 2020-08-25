using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Blog.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public void ContactSubmit(string name, string email, string phone, string message)
        {
            string myConnectionString = "Database=blog_db;Data Source=localhost;User Id=root;Password=";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);

            string myInsertQuery = "Insert into contacts (name, email, phone, message, user_id) " +
                $"Values ('{name}', '{email}', '{phone}', '{message}', 0)";

            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            Response.Redirect("/Contact/Index");
        }
    }
}