using Hi_Tech_Order_Management.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Order_Management.DAL
{
    class UserDB
    {
        public static User GetRecord(int userId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM users " + "WHERE UserId = " + userId;
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            User auser = new User();
            if (sqlReader.Read())
            {
                auser.UserId = Convert.ToInt32(sqlReader["UserId"]);
                auser.Password = sqlReader["Password"].ToString();
                auser.JobTitle = sqlReader["JobTitle"].ToString();
                auser.UserStatus = sqlReader["UserStatus"].ToString();
            }
            else
            {
                auser = null;
            }
            return auser;
        }
    }
}
