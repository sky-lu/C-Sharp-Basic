using Hi_Tech_Order_Management.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Order_Management.BLL
{
    class User
    {
        private int userId;
        private string password;
        private string jobTitle;
        private string userStatus;
        private static Dictionary<Int32, Int32> loginErrorCount = new Dictionary<Int32, Int32>();
       

        public User()
        {
            userId = 0;
            password = "";
            jobTitle = "";
            userStatus = "";

        }
        public User(int userId, string password, string jobTitle, string userStatus)
        {
            this.userId = userId;
            this.password = password;
            this.jobTitle = jobTitle;
            this.userStatus = userStatus;
        }

        

        public int UserId { get => userId; set => userId = value; }
        public string Password { get => password; set => password = value; }

        public string JobTitle { get => jobTitle; set => jobTitle = value; }


        public string UserStatus { get => userStatus; set => userStatus = value; }

        public static Dictionary<Int32, Int32> LoginErrorCount { get => loginErrorCount; set => loginErrorCount = value; }



        public User GetUser(int id)
        {
            return UserDB.GetRecord(id);
        }

        
        


    }
}
