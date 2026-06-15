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
    }
}
