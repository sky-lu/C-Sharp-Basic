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
        public static List<User> GetUserRecordList()
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
                auser.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                listUser.Add(auser);
            }
            connDB.Close();
            return listUser;
        }

        public static void SaveUserRecord (User aUser)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO Users (UserId, Password, EmployeeId)" +
                                    "VALUES (@UserId, @Password, @EmployeeId)";
            cmdInsert.Parameters.AddWithValue("@UserId", aUser.UserId);
            cmdInsert.Parameters.AddWithValue("@Password", aUser.Password);
            cmdInsert.Parameters.AddWithValue("@EmployeeId", aUser.EmployeeId);
            cmdInsert.Connection = connDB;
            cmdInsert.ExecuteNonQuery();
            connDB.Close();

        }

        
        public static User GetUsrRecordByUserId(int userId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Users WHERE UserId = @UserId";
            cmdSelect.Parameters.AddWithValue("@UserId", userId);
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            User aUser = new User();
            if (sqlReader.Read())
            {
                aUser.UserId = Convert.ToInt32(sqlReader["UserId"]);
                aUser.Password = sqlReader["Password"].ToString();
                aUser.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);

            }
            else
            {
                aUser = null;
            }
            connDB.Close();
            return aUser;

        }

        public static User GetUsrRecordByEmpId(int empId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Users WHERE EmployeeId = @EmployeeId";
            cmdSelect.Parameters.AddWithValue("@EmployeeId", empId);
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            User aUser = new User();
            if (sqlReader.Read())
            {
                aUser.UserId = Convert.ToInt32(sqlReader["UserId"]);
                aUser.Password = sqlReader["Password"].ToString();
                aUser.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);

            }
            else
            {
                aUser = null;
            }
            connDB.Close();
            return aUser;

        }

        public static void UpdateUserRecord(User auser)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.CommandText = "UPDATE Users SET Password = @Password, EmployeeId = @EmployeeId WHERE UserId = @UserId";
            cmdUpdate.Parameters.AddWithValue("@Password", auser.Password);
            cmdUpdate.Parameters.AddWithValue("@EmployeeId", auser.EmployeeId);
            cmdUpdate.Parameters.AddWithValue("@UserId", auser.UserId);
            cmdUpdate.Connection = connDB;
            cmdUpdate.ExecuteNonQuery();
            connDB.Close();
        }

        public static void DeleteUserRecord(int userId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM Users WHERE UserId = @UserId ";
            cmdDelete.Parameters.AddWithValue("@UserId", userId);
            cmdDelete.Connection = connDB;
            cmdDelete.ExecuteNonQuery();
            connDB.Close();

        }

        
    }
}
