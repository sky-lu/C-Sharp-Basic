using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormAppDisconnectedMode.BLL;
using System.Data.SqlClient;

namespace WinFormAppDisconnectedMode.DAL
{
    class StudentCourseDB
    {
        public static List<string> GetCourseCodeList (int studId)
        {
            List<string> lstCourseCode = new List<string>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT CourseCode FROM StudentCourses WHERE StudentId = @StudentId";
            cmdSelect.Parameters.AddWithValue("@StudentId", studId);
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            while (sqlReader.Read())
            {
                lstCourseCode.Add(sqlReader["CourseCode"].ToString());
            }
            connDB.Close();
            return lstCourseCode;
            
           
        }

        public static List<Course> GetCourseList(List<string> lstCode)
        {
            List<Course> listCourse = new List<Course>();
            foreach (var item in lstCode)
            {
                
                SqlConnection connDB = UtilityDB.ConnectDB();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.CommandText = "SELECT * FROM Courses WHERE CourseCode = @CourseCode";
                cmdSelect.Parameters.AddWithValue("@CourseCode", item);
                cmdSelect.Connection = connDB;
                SqlDataReader sqlReader = cmdSelect.ExecuteReader();
                Course aCourse = new Course();
                if (sqlReader.Read())
                {
                    aCourse.CourseCode = sqlReader["CourseCode"].ToString();
                    aCourse.CourseTitle = sqlReader["CourseTitle"].ToString();
                    aCourse.TotalHour = Convert.ToInt32(sqlReader["TotalHour"]);
                }
                listCourse.Add(aCourse);
                connDB.Close();
            }
            return listCourse;
                    
        }

        public static List<int> GetStudIdList(string courseCode)
        {
            List<int> lstStudId = new List<int>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT StudentId FROM StudentCourses WHERE CourseCode = @CourseCode";
            cmdSelect.Parameters.AddWithValue("@CourseCode", courseCode);
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            while (sqlReader.Read())
            {
                lstStudId.Add(Convert.ToInt32(sqlReader["StudentId"]));
            }
            connDB.Close();
            return lstStudId;

        }

        public static List<Student> GetStudentList(List<int> lstId)
        {
            List<Student> listStud = new List<Student>();
            foreach (var item in lstId)
            {

                SqlConnection connDB = UtilityDB.ConnectDB();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.CommandText = "SELECT * FROM Students WHERE StudentId = @StudentId";
                cmdSelect.Parameters.AddWithValue("@StudentId", item);
                cmdSelect.Connection = connDB;
                SqlDataReader sqlReader = cmdSelect.ExecuteReader();
                Student aStud = new Student();
                if (sqlReader.Read())
                {
                    aStud.StudentId = Convert.ToInt32(sqlReader["StudentId"]);
                    aStud.FirstName = sqlReader["FirstName"].ToString();
                    aStud.LastName = sqlReader["LastName"].ToString();
                    aStud.Email = sqlReader["Email"].ToString();
                }
                listStud.Add(aStud);
                connDB.Close();
            }
            return listStud;

        }
    }
}
