using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer.Users
{
    public class BNUser
    {
        string username;
        string password;
        byte isActive;

        BNUser(string userName,string PassWord,byte isActive ) {
            this.username = userName;
            this.password = PassWord;
            this.isActive = isActive;
        }



        public static bool checkIfUserExists(string userName,string pass)
        {
            return DVL_Data_Access_Layer.Users.DBAUser.CheckIfUserExistsAndActive(userName, pass);
        }

        public static DataTable GetAllUsers()
        {
            return DVL_Data_Access_Layer.Users.DBAUser.GetAllUser();
        }

        public static int GetCountAllUsers()
        {
            return DVL_Data_Access_Layer.Users.DBAUser.GetUserCount();
        }

        public static int AddUser(int personId,string userName, string passWord, bool isActive)
        {
            return DVL_Data_Access_Layer.Users.DBAUser.AddUser(
                personId, userName, passWord, isActive
                );
        }


        public static DataTable FindUserByColums(string columnName,string columnValue)
        {
            return DVL_Data_Access_Layer.Users.DBAUser.FindUserByColums(columnName,columnValue);
        }

        public static bool DeletUser(int userID)
        {
            return DVL_Data_Access_Layer.Users.DBAUser.DeleteUser(userID);
        }

        public static DataTable FindUserByID(int userID) {
            return DVL_Data_Access_Layer.Users.DBAUser.FindUserById(userID);
        }

        public static bool UpdateUser(int userID,
            int personID,
            string userName,
            string password,
            bool isActive)
        {
            return DVL_Data_Access_Layer.Users.DBAUser.UpdateUser(userID,personID,userName,password,isActive);
        }

        public static bool UpdatePassword(int userID, string password) { 
            return DVL_Data_Access_Layer.Users.DBAUser.UpdatePassword(userID,password);
        }

        public static bool CheckIfPasswordCorrect(int userID, string password){
            return DVL_Data_Access_Layer.Users.DBAUser.CheckIfPasswordCorrect(userID, password);
        }

    }
}
