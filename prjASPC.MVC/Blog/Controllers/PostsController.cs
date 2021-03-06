﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Collections;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System.Web;

namespace Blog.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            string myConnectionString = "Database=blog_db;Data Source=localhost;User Id=root;Password=";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);

            string mySelectQuery = "SELECT id, title, publish_date FROM posts WHERE publish_date >= '2020-07-19'";

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
                    ht.Add("title", myReader.GetString(1));
                    ht.Add("publish_date", myReader.GetString(2));
                    //Console.WriteLine(myReader.GetString(1));
                    al.Add(ht);
                }
            }
            finally
            {
                myReader.Close();
                myConnection.Close();
            }


            ViewBag.data = al;

            return View();
        }

        public IActionResult Detail(int id)
        {
            string myConnectionString = "Database=blog_db;Data Source=localhost;User Id=root;Password=";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);

            string mySelectQuery = $"SELECT title, context FROM posts WHERE id = {id}";

            MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);
            myConnection.Open();

            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try { 
                while (myReader.Read()) { 

                    ViewBag.titleBlog = myReader.GetString(0);
                    ViewBag.context = myReader.GetString(1);
                }
            }
            finally
            {
                myReader.Close();
                myConnection.Close();
            }
            return View("samplePost");
        }

        public IActionResult List()
        {
            string myConnectionString = "Database=blog_db;Data Source=localhost;User Id=root;Password=";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);

            string mySelectQuery = "SELECT id, title FROM posts";

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
                    ht.Add("title", myReader.GetString(1));
                    //Console.WriteLine(myReader.GetString(1));
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
        
        public IActionResult Add()
        {
            return View("Add");
        }

        public void Submit(string PostTitle, string PostContext)
        {
            //PostContext = HttpUtility.HtmlEncode(PostContext);
            string myConnectionString = "Database=blog_db;Data Source=localhost;User Id=root;Password=";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            string publishDate = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString();

            string myInsertQuery = $"INSERT INTO posts (title, publish_date, context, user_id) Values('{PostTitle}', '{publishDate}', '{PostContext}', 1)";

            //System.Console.WriteLine(myInsertQuery);
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            Response.Redirect("/posts/list");
        }

        public IActionResult Delete(int id)
        {
            string myConnectionString = "Database=blog_db;Data Source=localhost;User Id=root;Password=";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            string myInsertQuery = $"DELETE FROM posts WHERE id = {id}";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            return this.List();
        }

        public IActionResult Edit(int id)
        {
            string myConnectionString = "Database=blog_db;Data Source=localhost;User Id=root;Password=";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            string mySelectQuery = $"SELECT title, context FROM posts WHERE id = {id}";
            MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);
            myConnection.Open();

            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    ViewBag.idBlog = id;
                    ViewBag.titleBlog = myReader.GetString(0);

                    //ViewBag.context = HttpUtility.HtmlDecode(myReader.GetString(1));
                    ViewBag.context = myReader.GetString(1);
                   
                }
                
            }
            finally
            {
                myReader.Close();
                myConnection.Close();
            }

            return View("add");
        }

        public void Update(string PostTitle, string PostContext, int id)
        {
            string myConnectionString = "Database=blog_db;Data Source=localhost;User Id=root;Password=";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            string myInsertQuery = $"UPDATE posts set title = '{PostTitle}', context = '{PostContext}' WHERE id = {id}";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();

            //Redirect("/posts/list");
            Response.Redirect("/posts/list");
        }

    }
}