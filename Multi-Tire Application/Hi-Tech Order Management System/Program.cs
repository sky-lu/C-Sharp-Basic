﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management_System.GUI;

namespace Hi_Tech_Order_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MIS_ManagerForm());
            //Application.Run(new Customer_Management_Form());
            //Application.Run(new Book_Management_Form());
            //Application.Run(new Order_Management_Form());
            Application.Run(new Login_Form());
        }
    }
}
