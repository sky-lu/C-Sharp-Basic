using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WinFormAppDisconnectedMode.DAL
{
    public static class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection connDB = new SqlConnection();
            connDB.ConnectionString = ConfigurationManager.ConnectionStrings["CollegeDB_Connection"].ConnectionString;
            connDB.Open();
            return connDB;
        }
    }
}
