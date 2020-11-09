using Hi_Tech_Order_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Order_Management_System.DAL
{
    class JobDB
    {
        public static List<Job> GetJobRecords()
        {
            List<Job> lstJob = new List<Job>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Jobs", connDB);
            SqlDataReader sqlReader = cmdSelect.ExecuteReader();
            Job aJob;
            while (sqlReader.Read())
            {
                aJob = new Job();
                aJob.JobId = Convert.ToInt32(sqlReader["JobId"]);
                aJob.JobTitle = sqlReader["JobTitle"].ToString();
                aJob.Description = sqlReader["Description"].ToString();
                lstJob.Add(aJob);
            }
            return lstJob;
        }

        
    }
}
