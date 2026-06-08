using DVL_Data_Access_Layer.DataAccessSetting;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace DVL_Data_Access_Layer
{
    public class Countries
    {
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
    }
}