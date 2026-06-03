using DVL_Data_Access_Layer.DataAccessSetting;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DVL_Data_Access_Layer.People
{
    public class BDAPeople
    {
        public static bool AddPerson(
            string NationalID,
            string FirstName,
            string SecondName,
            string ThirdName,
            string LastName,
            DateTime DateOfBirth,
            byte Gender,
            string Address,
            string Phone,
            string Email,
            int NationalityCountryID,
            string ImagePath)
        {
            int RowsAffected = 0;

            SqlConnection Connection =
                new SqlConnection(DataBaseSetting.ConnectionString);

            string Query = @"INSERT INTO People
                            (
                                NationalID,
                                FirstName,
                                SecondName,
                                ThirdName,
                                LastName,
                                DateOfBirth,
                                Gender,
                                Address,
                                Phone,
                                Email,
                                NationalityCountryID,
                                ImagePath
                            )
                            VALUES
                            (
                                @NationalID,
                                @FirstName,
                                @SecondName,
                                @ThirdName,
                                @LastName,
                                @DateOfBirth,
                                @Gender,
                                @Address,
                                @Phone,
                                @Email,
                                @NationalityCountryID,
                                @ImagePath
                            )";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@NationalID", NationalID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);

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

        public static bool UpdatePerson(
            int PersonID,
            string NationalID,
            string FirstName,
            string SecondName,
            string ThirdName,
            string LastName,
            DateTime DateOfBirth,
            byte Gender,
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
                             SET NationalID = @NationalID,
                                 FirstName = @FirstName,
                                 SecondName = @SecondName,
                                 ThirdName = @ThirdName,
                                 LastName = @LastName,
                                 DateOfBirth = @DateOfBirth,
                                 Gender = @Gender,
                                 Address = @Address,
                                 Phone = @Phone,
                                 Email = @Email,
                                 NationalityCountryID = @NationalityCountryID,
                                 ImagePath = @ImagePath
                             WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@NationalID", NationalID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gender", Gender);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);

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

                    NationalID = Reader["NationalID"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    ThirdName = Reader["ThirdName"].ToString();
                    LastName = Reader["LastName"].ToString();
                    DateOfBirth = Convert.ToDateTime(Reader["DateOfBirth"]);
                    Gender = Convert.ToByte(Reader["Gender"]);
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
  }
}