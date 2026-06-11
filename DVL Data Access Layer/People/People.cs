using DVL_Data_Access_Layer.DataAccessSetting;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Net;

namespace DVL_Data_Access_Layer.People
{
    public class BDAPeople
    {

        // Add New Person
        public static int AddPerson(
           string NationalNo,
           string FirstName,
           string SecondName,
           string ThirdName,
           string LastName,
           DateTime DateOfBirth,
           int Gender,
           string Address,
    string Phone,
    string Email,
    int NationalityCountryID,
    string ImagePath)
        {
            int insertedId = -1;

            string Query = @"
    INSERT INTO People
    (
        NationalNo,
        FirstName,
        SecondName,
        ThirdName,
        LastName,
        DateOfBirth,
        Gendor,
        Address,
        Phone,
        Email,
        NationalityCountryID,
        ImagePath
    )
    VALUES
    (
        @NationalNo,
        @FirstName,
        @SecondName,
        @ThirdName,
        @LastName,
        @DateOfBirth,
        @Gendor,
        @Address,
        @Phone,
        @Email,
        @NationalityCountryID,
        @ImagePath
    );

    SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlConnection Connection =
                    new SqlConnection(DataBaseSetting.ConnectionString))
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    Command.Parameters.AddWithValue("@FirstName", FirstName);
                    Command.Parameters.AddWithValue("@SecondName", SecondName);
                    Command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    Command.Parameters.AddWithValue("@LastName", LastName);
                    Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    Command.Parameters.AddWithValue("@Gendor", Gender);
                    Command.Parameters.AddWithValue("@Address", Address);
                    Command.Parameters.AddWithValue("@Phone", Phone);
                    Command.Parameters.AddWithValue("@Email", Email);
                    Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                    Command.Parameters.AddWithValue("@ImagePath", ImagePath ?? (object)DBNull.Value);

                    Connection.Open();

                    object result = Command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        insertedId = id;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting person: " + ex.Message, ex);
            }

            return insertedId;
        }


        // Update Person
        public static bool UpdatePerson(
            int PersonID,
            string NationalNo,
            string FirstName,
            string SecondName,
            string ThirdName,
            string LastName,
            DateTime DateOfBirth,
            int Gendor,
            string Address,
            string Phone,
            string Email,
            int NationalityCountryID,
            string ImagePath)
        {
            int RowsAffected = 0;

            SqlConnection Connection =
                new SqlConnection(DataBaseSetting.ConnectionString);

            string Query = @"UPDATE People
                     SET NationalNo = @NationalNo,
                         FirstName = @FirstName,
                         SecondName = @SecondName,
                         ThirdName = @ThirdName,
                         LastName = @LastName,
                         DateOfBirth = @DateOfBirth,
                         Gendor = @Gendor,
                         Address = @Address,
                         Phone = @Phone,
                         Email = @Email,
                         NationalityCountryID = @NationalityCountryID,
                         ImagePath = @ImagePath
                     WHERE PersonID = @PersonID";


            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath ?? (object)DBNull.Value);

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

        // Delete Person
        public static bool DeletePerson(int PersonID)
        {
            int RowsAffected = 0;

            SqlConnection Connection =
                new SqlConnection(DataBaseSetting.ConnectionString);

            string Query = "DELETE FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

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


        // Get All People
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection =
                new SqlConnection(DataBaseSetting.ConnectionString);

            string Query = "SELECT * FROM People";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return dt;
        }


        // Count People
        public static int CountsOfPeopls()
        {
            int count = 0;

            SqlConnection Connection =
             new SqlConnection(DataBaseSetting.ConnectionString);

            string Query = "SELECT COUNT(*) FROM People";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                count = (int)Command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return count;
        }


        // Find Person By ID
        public static bool FindPersonByID(
            int PersonID,
            ref string NationalID,
            ref string FirstName,
            ref string SecondName,
            ref string ThirdName,
            ref string LastName,
            ref DateTime DateOfBirth,
            ref byte Gender,
            ref string Address,
            ref string Phone,
            ref string Email,
            ref int NationalityCountryID,
            ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection =
                new SqlConnection(DataBaseSetting.ConnectionString);

            string Query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    NationalID = Reader["NationalNo"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    ThirdName = Reader["ThirdName"].ToString();
                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gender = Convert.ToByte(Reader["Gendor"]);
                    Address = Reader["Address"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Email = Reader["Email"].ToString();
                    NationalityCountryID = Convert.ToInt32(Reader["NationalityCountryID"]);
                    ImagePath = Reader["ImagePath"].ToString();
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        // Find Person By National Number
        public static bool FindNationaNumber(string NationalNo)
        {
            bool IsFound = false;

            SqlConnection Connection =
                new SqlConnection(DataBaseSetting.ConnectionString);

            string Query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);


            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }


        // Find Person By Column
        public static DataTable FindByColumn(string ColumnName, string columnValue)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(DataBaseSetting.ConnectionString))
            {
                string query = $"SELECT * FROM People WHERE {ColumnName} LIKE @Value";

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


        
    }
}