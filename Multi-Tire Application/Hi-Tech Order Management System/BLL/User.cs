using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DAL;

namespace Hi_Tech_Order_Management_System.BLL
{
    public class User
    {
        private int userId;
        private string password;
        private string firstName;
        private string lastName;
        private string jobTitle;
        private string userStatus;

        public int UserId { get => userId; set => userId = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public string UserStatus { get => userStatus; set => userStatus = value; }

        public List<User> GetUserList()
        {
            return UserDB.GetRecordList();
        }

        public void SaveUser(User aUser)
        {
            UserDB.SaveRecord(aUser);
        }
    }
}
