using Hi_TechLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_TechLibrary.BLL
{
    public class User
    {
        private int userId;
        private string password;
        private int employeeId;

        public int UserId { get => userId; set => userId = value; }
        public string Password { get => password; set => password = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }

        public List<User> GetUserList()
        {
            return UserDB.GetUserRecordList();
        }

        public void SaveUser(User auser)
        {
            UserDB.SaveUserRecord(auser);
        }

        public User GetUser(int userId)
        {
            return UserDB.GetUsrRecordByUserId(userId);
        }

        public void UpdateUser(User auser)
        {
            UserDB.UpdateUserRecord(auser);
        }

        public void DeleteUser(int userId)
        {
            UserDB.DeleteUserRecord(userId);
        }

        public User GetUserByEmpId(int empId)
        {
            return UserDB.GetUsrRecordByEmpId(empId);
        }
    }
}
