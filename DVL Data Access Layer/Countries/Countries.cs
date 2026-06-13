using DVL_Data_Access_Layer.DataAccessSetting;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DVL_Data_Access_Layer
{
    public class Countries
    {

        // Get All Name Of Countrys
        public static string[] GetAllCountries()
        {
            List<string> countries = new List<string>();

            using (SqlConnection connection =
                new SqlConnection(DataBaseSetting.ConnectionString))
            {
                string query = "SELECT CountryName FROM Countries";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                countries.Add(reader["CountryName"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return countries.ToArray();
        }


        public static string GetCountry(int countryID)
        {
            string countryName = string.Empty;

            const string query = @"
        SELECT CountryName
        FROM Countries
        WHERE CountryID = @CountryID;";

            using (SqlConnection connection =
                   new SqlConnection(DataBaseSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@CountryID", SqlDbType.Int).Value = countryID;

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        countryName = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error getting country: {ex.Message}");
                }
            }

            return countryName;
        }

    }
}