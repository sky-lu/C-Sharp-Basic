using Hi_Tech_Order_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Order_Management_System.DAL
{
    class UserDB
    {
        public static List<User> GetRecordList()
        {
            List<User> listUser = new List<User>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Users", connDB);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            User auser;
            while (sqlReader.Read())
            {
                auser = new User();
                auser.UserId = Convert.ToInt32(sqlReader["UserId"]);
                auser.Password = sqlReader["Password"].ToString();
                auser.FirstName = sqlReader["FirstName"].ToString();
                auser.LastName = sqlReader["LastName"].ToString();
                auser.JobTitle = sqlReader["JobTitle"].ToString();
                auser.UserStatus = sqlReader["UserStatus"].ToString();
                listUser.Add(auser);
            }
            connDB.Close();
            return listUser;
        }

        public static void SaveRecord (User aUser)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO Users (UserId, Password, FirstName, LastName, JobTitle, UserStatus)" +
                                    "VALUES (@UserId, @Password, @FirstName, @LastName, @JobTitle, @UserStatus)";
            cmdInsert.Parameters.AddWithValue("@UserId", aUser.UserId);
            cmdInsert.Parameters.AddWithValue("@Password", aUser.Password);
            cmdInsert.Parameters.AddWithValue("@FirstName", aUser.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", aUser.LastName);
            cmdInsert.Parameters.AddWithValue("@JobTitle", aUser.JobTitle);
            cmdInsert.Parameters.AddWithValue("@UserStatus", aUser.UserStatus);
            cmdInsert.Connection = connDB;
            cmdInsert.ExecuteNonQuery();
            connDB.Close();

        }

        public static User GetRecord(int userId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM User WHERE UserId = @UserId";
            cmdSelect.Parameters.AddWithValue("@UserId", userId);
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            User aUser = new User();
            if (sqlReader.Read())
            {
                aUser.UserId = Convert.ToInt32(sqlReader["UserId"]);
                aUser.Password = sqlReader["Password"].ToString();
                aUser.FirstName = sqlReader["FirstName"].ToString();
                aUser.LastName = sqlReader["LastName"].ToString();
                aUser.JobTitle = sqlReader["JobTitle"].ToString();
                aUser.UserStatus = sqlReader["UserStatus"].ToString();

            }
            else
            {
                aUser = null;
            }
            connDB.Close();
            return aUser;

        }
    }
}
