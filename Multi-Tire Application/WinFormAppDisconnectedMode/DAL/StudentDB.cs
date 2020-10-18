using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormAppDisconnectedMode.BLL;
using System.Data.SqlClient;

namespace WinFormAppDisconnectedMode.DAL
{
    public static class StudentDB
    {
        public static List<Student> GetRecordList()
        {
            List<Student> listStu = new List<Student>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand("Select * From Students", connDB);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Student stu;
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    stu = new Student();
                    stu.StudentId = Convert.ToInt32(sqlReader["StudentId"]);
                    stu.FirstName = sqlReader["FirstName"].ToString();
                    stu.LastName = sqlReader["LastName"].ToString();
                    stu.Email = sqlReader["Email"].ToString();
                    listStu.Add(stu);
                }
            }
            else
            {
                listStu = null;
            }
            return listStu;
        }  
    }
}
