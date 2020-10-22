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
            return listUser;
        }
    }
}
