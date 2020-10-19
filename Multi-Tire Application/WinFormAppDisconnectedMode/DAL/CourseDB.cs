using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormAppDisconnectedMode.BLL;

namespace WinFormAppDisconnectedMode.DAL
{
    public static class CourseDB
    {
        public static List<Course> GetRecordList()
        {
            List<Course> listCour = new List<Course>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand("Select * From Courses", connDB);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Course cour;
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    cour = new Course();
                    cour.CourseCode = sqlReader["CourseCode"].ToString();
                    cour.CourseTitle = sqlReader["CourseTitle"].ToString();
                    cour.TotalHour = Convert.ToInt32(sqlReader["TotalHour"]);
                    
                    listCour.Add(cour);
                }
            }
            else
            {
                listCour = null;
            }
            return listCour;
        }
    }
}
