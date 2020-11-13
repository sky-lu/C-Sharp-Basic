using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DAL;

namespace Hi_Tech_Order_Management_System.BLL
{
    public class Job
    {
        private int jobId;
        private string jobTitle;
        private string description;

        public int JobId { get => jobId; set => jobId = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public string Description { get => description; set => description = value; }

        public List<Job> GetJobs()
        {
            return JobDB.GetJobRecords();
        }

        public string GetJobTitle(int jobId)
        {
            return JobDB.GetJobTitleRecord(jobId);
        }
    }
}
