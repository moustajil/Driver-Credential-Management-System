using DVL_Data_Access_Layer.DataAccessSetting;
using Microsoft.Data.SqlClient;
using System;
using System.Data;


namespace DVL_Data_Access_Layer
{
    public class LicenseClasses
    {
        // Get all license class names
        public static DataTable GetAllClassNames()
        {
            DataTable classNames = new DataTable();

            using (SqlConnection connection =
                   new SqlConnection(DataBaseSetting.ConnectionString))
            {
                const string query =
                    "SELECT ClassName FROM LicenseClasses ORDER BY ClassName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            classNames.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(
                            "An error occurred while retrieving license classes.",
                            ex
                        );
                    }
                }
            }

            return classNames;
        }
    }
}