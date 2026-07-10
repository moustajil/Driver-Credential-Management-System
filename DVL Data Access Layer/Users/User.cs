using DVL_Data_Access_Layer.DataAccessSetting;
using System.Data.SqlClient;
using System;
using System.Configuration;
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


        // Find User By ID
        public static DataTable FindUserById(int UserID) {
            DataTable dt = new DataTable();
            SqlConnection Connection =
                new SqlConnection(DataBaseSetting.ConnectionString);

            string query = "Select * From Users WHERE UserID = @UserID";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@UserID", UserID);

                try
                {
                    Connection.Open();

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

            return dt;
        }


        // Find User By PersonID
        public static DataTable FindUserByPersonID(int PersonID)
        {
            DataTable dt = new DataTable();
            SqlConnection Connection =
                new SqlConnection(DataBaseSetting.ConnectionString);

            string query = "Select * From Users WHERE PersonID = @PersonID";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    Connection.Open();

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

            return dt;
        }


        // update user

        // Updates a user record in the database.
        public static bool UpdateUser(
            int userID,
            int personID,
            string userName,
            string password,
            bool isActive)
        {
            int rowsAffected = 0;

            using (SqlConnection Connection =
                new SqlConnection(DataBaseSetting.ConnectionString))
            {
                string query = @"
            UPDATE Users
            SET PersonID = @PersonID,
                UserName = @UserName,
                Password = @Password,
                IsActive = @IsActive
            WHERE UserID = @UserID;";

                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@PersonID", personID);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@IsActive", isActive);

                    try
                    {
                        Connection.Open();

                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }

            return rowsAffected > 0;
        }

        // update password
        // Updates the password of a specific user.
        public static bool UpdatePassword(int userID, string newPassword)
        {
            const string query = @"
        UPDATE Users
        SET Password = @Password
        WHERE UserID = @UserID;";

            try
            {
                using (SqlConnection connection =
                       new SqlConnection(DataBaseSetting.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 100).Value =
                        newPassword;

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating password: {ex.Message}");
                return false;
            }
        }

        // check if password is correct
        // Checks whether the entered password matches the specified user.
        public static bool CheckIfPasswordCorrect(int userID, string password)
        {
            const string query = @"
        SELECT COUNT(1)
        FROM Users
        WHERE UserID = @UserID
          AND Password = @Password;";

            try
            {
                using (SqlConnection connection =
                       new SqlConnection(DataBaseSetting.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 100).Value =
                        password ?? string.Empty;

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking password: {ex.Message}");
                return false;
            }
        }
    }
}
