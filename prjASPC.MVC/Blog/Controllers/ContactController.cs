using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Collections;
using Microsoft.AspNetCore.Http;

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
            string myConnectionString = "Database=blog_db;Data Source=localhost;User Id=root;Password=";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);

            string mySelectQuery = "SELECT id, name, email, phone, message FROM contacts";

            MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);
            myConnection.Open();

            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            ArrayList al = new ArrayList();
            try
            {
                while (myReader.Read())
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("id", myReader.GetString(0));
                    ht.Add("name", myReader.GetString(1));
                    ht.Add("email", myReader.GetString(2));
                    ht.Add("phone", myReader.GetString(3));
                    ht.Add("message", myReader.GetString(4));
                    al.Add(ht);
                }
            }
            finally
            {
                myReader.Close();
                myConnection.Close();
            }
            ViewBag.data = al;

            return View("List");
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