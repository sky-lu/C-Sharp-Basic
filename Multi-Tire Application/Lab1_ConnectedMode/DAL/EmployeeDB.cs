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
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.CommandText = "INSERT INTO Employees (EmployeeId, FirstName, LastName, JobTitle)" +
                "VALUES (@EmployeeId, @FirstName, @LastName, @JobTitle)";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
            cmdInsert.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdInsert.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
            cmdInsert.Connection = connDB;
            cmdInsert.ExecuteNonQuery();
            connDB.Close();
        }

        public static Employee GetRecord(int empId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.CommandText = "SELECT * FROM Employees " + "WHERE EmployeeId = " + empId;
            cmdSelect.Connection = connDB;
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp = new Employee();
            if (sqlReader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
            }
            else
            {
                emp = null;
            }
            return emp;
        }

        public static List<Employee> GetRecordList()
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
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                listEmp.Add(emp);
            }
            return listEmp;
        }

        public static void UpdateRecord(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.CommandText = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, JobTitle = @JobTitle WHERE EmployeeId = @EmployeeId";
            cmdUpdate.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);//if you change the id, you have to check first if there is duplicated id;
            cmdUpdate.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdUpdate.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdUpdate.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
            cmdUpdate.Connection = connDB;
            cmdUpdate.ExecuteNonQuery();
            connDB.Close();
        }

        public static void DeleteRecord(int empId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.CommandText = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId ";
            cmdDelete.Parameters.AddWithValue("@EmployeeId", empId);
            cmdDelete.Connection = connDB;
            cmdDelete.ExecuteNonQuery();
            connDB.Close();

        }
        public static List<Employee> GetRecordList(int index, string name)
        {
            string colName = null;
            string paramName = null;
            switch (index)
            {
                case 1:
                    colName = "FirstName";
                    break;
                case 2:
                    colName = "LastName";
                    break;
                default:
                    break;
            }
            paramName = "@" + colName;

            List<Employee> listEmp = new List<Employee>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand($"SELECT * FROM Employees WHERE {colName} = {paramName}", connDB);
            cmdSelect.Parameters.AddWithValue(paramName, name);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Employee emp;
            while (sqlReader.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                listEmp.Add(emp);
            }
            return listEmp;
        }
    }
}
