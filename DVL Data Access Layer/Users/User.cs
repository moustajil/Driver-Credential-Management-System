using DVL_Data_Access_Layer.DataAccessSetting;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DVL_Data_Access_Layer.Users
{
    public class DBAUser
    {
        // Check if user exists and is active
        public static bool CheckIfUserExistsAndActive(string username, string password)
        {
            bool isFound = false;

            string query = @"
                SELECT 1
                FROM Users
                WHERE UserName = @UserName
                  AND Password = @Password
                  AND IsActive = 1";

            using (SqlConnection connection =
                   new SqlConnection(DataBaseSetting.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.Read();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return isFound;
        }


        // Get All Users
        public static DataTable GetAllUser()
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT 
            UserID,
            PersonID,
            UserName,
            IsActive
        FROM Users";

            using (SqlConnection connection = new SqlConnection(DataBaseSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return dt;
        }
    }
}