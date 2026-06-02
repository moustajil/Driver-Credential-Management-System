using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess_Layer
{
    public class ClsPeopleManagement
    {
        SqlConnection conn;

        private void OpenConnection()
        {
            conn = new SqlConnection(DataAccess.ConnectionString);
            conn.Open();
        }

        private void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // GET ALL PEOPLE
        public DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();

                string query = "SELECT * FROM People";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                reader.Close();
                CloseConnection();
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw new Exception("Error loading people: " + ex.Message);
            }

            return dt;
        }

        // ADD PERSON
        public bool AddPerson(
            string nationalId,
            string firstName,
            string secondName,
            string thirdName,
            string lastName,
            DateTime dateOfBirth,
            string gender,
            string address,
            string phone,
            string email,
            int nationalityCountryId,
            string imagePath)
        {
            try
            {
                OpenConnection();

                string query = @"
                INSERT INTO People
                (NationalID, FirstName, SecondName, ThirdName, LastName,
                 DateOfBirth, Gender, Address, Phone, Email,
                 NationalityCountryID, ImagePath)
                VALUES
                (@NationalID, @FirstName, @SecondName, @ThirdName, @LastName,
                 @DateOfBirth, @Gender, @Address, @Phone, @Email,
                 @NationalityCountryID, @ImagePath)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@NationalID", nationalId);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@SecondName", secondName);
                cmd.Parameters.AddWithValue("@ThirdName", thirdName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryId);
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                int rows = cmd.ExecuteNonQuery();

                CloseConnection();
                return rows > 0;
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw new Exception("Error adding person: " + ex.Message);
            }
        }

        // UPDATE PERSON
        public bool UpdatePerson(
            int personId,
            string nationalId,
            string firstName,
            string secondName,
            string thirdName,
            string lastName,
            DateTime dateOfBirth,
            string gender,
            string address,
            string phone,
            string email,
            int nationalityCountryId,
            string imagePath)
        {
            try
            {
                OpenConnection();

                string query = @"
                UPDATE People
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

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PersonID", personId);
                cmd.Parameters.AddWithValue("@NationalID", nationalId);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@SecondName", secondName);
                cmd.Parameters.AddWithValue("@ThirdName", thirdName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryId);
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                int rows = cmd.ExecuteNonQuery();

                CloseConnection();
                return rows > 0;
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw new Exception("Error updating person: " + ex.Message);
            }
        }

        // DELETE PERSON
        public bool DeletePerson(int personId)
        {
            try
            {
                OpenConnection();

                string query = "DELETE FROM People WHERE PersonID = @PersonID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PersonID", personId);

                int rows = cmd.ExecuteNonQuery();

                CloseConnection();
                return rows > 0;
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw new Exception("Error deleting person: " + ex.Message);
            }
        }
    }
}