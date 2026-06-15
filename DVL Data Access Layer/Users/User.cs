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


        // Get Count All Users
        public static int GetUserCount()
        {
            int count = 0;

            string query = @"SELECT COUNT(*) FROM Users";

            using (SqlConnection connection = new SqlConnection(DataBaseSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        count = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return count;
        }

        // Add User 
        public static int AddUser(
    int personID,
    string username,
    string password,
    bool isActive)
        {
            int userID = -1;

            string query = @"
        INSERT INTO Users
        (
            PersonID,
            UserName,
            Password,
            IsActive
        )
        VALUES
        (
            @PersonID,
            @UserName,
            @Password,
            @IsActive
        );

        SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection =
                   new SqlConnection(DataBaseSetting.ConnectionString))
            {
                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@PersonID",
                        personID);

                    command.Parameters.AddWithValue(
                        "@UserName",
                        username);

                    command.Parameters.AddWithValue(
                        "@Password",
                        password);

                    command.Parameters.AddWithValue(
                        "@IsActive",
                        isActive);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null &&
                            int.TryParse(result.ToString(), out int insertedID))
                        {
                            userID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(
                            $"Error adding user: {ex.Message}");

                        userID = -1;
                    }
                }
            }

            return userID;
        }


        // Filter User By Colum
        public static DataTable FindUserByColums(string ColumnName, string columnValue)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(DataBaseSetting.ConnectionString))
            {
                string query = $"SELECT * FROM Users WHERE {ColumnName} LIKE @Value";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", "%" + columnValue + "%");

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return dt;
        }

        // Delete User
        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;

            SqlConnection Connection =
                new SqlConnection(DataBaseSetting.ConnectionString);

            string Query = "DELETE FROM Users WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;
        }

    }
}