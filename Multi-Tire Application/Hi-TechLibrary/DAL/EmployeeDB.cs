using Hi_TechLibrary.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_TechLibrary.DAL
{
    public class EmployeeDB
    {
        public static void SaveEmployeeRecord(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO Employees (EmployeeId, FirstName, LastName, PhoneNumber, Email, JobId)" +
                                    "VALUES (@EmployeeId, @FirstName, @LastName, @PhoneNumber, @Email, @JobId)";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmdInsert.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
            cmdInsert.Parameters.AddWithValue("@Email", emp.Email);
            cmdInsert.Parameters.AddWithValue("@JobId", emp.JobId);
            cmdInsert.Connection = connDB;
            cmdInsert.ExecuteNonQuery();
            connDB.Close();
        }

        public static Employee GetEmployeeRecord(int empId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Employees WHERE EmployeeId = @EmployeeId";
            cmdSelect.Parameters.AddWithValue("@EmployeeId", empId);
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp = new Employee();
            if (sqlReader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.PhoneNumber = sqlReader["PhoneNumber"].ToString();
                emp.Email = sqlReader["Email"].ToString();
                emp.JobId = Convert.ToInt32(sqlReader["JobId"]);

            }
            else
            {
                emp = null;
            }
            return emp;
        }

        public static List<Employee> GetEmployeeRecordList()
        {
            List<Employee> listEmp = new List<Employee>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Employees", connDB);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp;
            while (sqlReader.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.LastName = sqlReader["LastName"].ToString();
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.PhoneNumber = sqlReader["PhoneNumber"].ToString();
                emp.Email = sqlReader["Email"].ToString();
                emp.JobId = Convert.ToInt32(sqlReader["JobId"]);

                listEmp.Add(emp);
            }
            return listEmp;
        }

        public static List<Employee> GetEmployeeRecordList(string Lname)
        {

            List<Employee> listEmp = new List<Employee>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Employees WHERE LastName = @LastName", connDB);
            cmdSelect.Parameters.AddWithValue("@LastName", Lname);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp;
            while (sqlReader.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.PhoneNumber = sqlReader["PhoneNumber"].ToString();
                emp.Email = sqlReader["Email"].ToString();
                emp.JobId = Convert.ToInt32(sqlReader["JobId"]);
                listEmp.Add(emp);
            }
            return listEmp;
        }

        public static void UpdateEmployeeRecord(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.CommandText = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Email = @Email, JobId = @JobId WHERE EmployeeId = @EmployeeId";
            cmdUpdate.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmdUpdate.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdUpdate.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdUpdate.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
            cmdUpdate.Parameters.AddWithValue("@Email", emp.Email);
            cmdUpdate.Parameters.AddWithValue("@JobId", emp.JobId);

            cmdUpdate.Connection = connDB;
            cmdUpdate.ExecuteNonQuery();
            connDB.Close();
        }

        public static void DeleteEmployeeRecord(int empId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId ";
            cmdDelete.Parameters.AddWithValue("@EmployeeId", empId);
            cmdDelete.Connection = connDB;
            cmdDelete.ExecuteNonQuery();
            connDB.Close();

        }
    }
}
