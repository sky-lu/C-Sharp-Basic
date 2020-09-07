using Lab1_ConnectedModel.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_ConnectedModel.DAL
{
    class EmployeeDB
    {
        public static void SaveRecord(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO Employees " + "VALUES(" + emp.EmployeeId +
                "," + "'" + emp.FirstName + "'," + "'" + emp.LastName + "'," + "'" + emp.JobTitle +
                "')";
            cmd.ExecuteNonQuery();
            connDB.Close();
        }
    }
}
