using System;
using System.Data;
using Microsoft.Data.SqlClient;


namespace DVL_Data_Access_Layer.Application
{
    public static class DBAApplicationType
    {
        // Gets all application types from the database.
        public static DataTable GetAllApplicationTypes()
        {
            DataTable applicationTypesTable = new DataTable();

            string query = @"
                SELECT
                    ApplicationTypeID,
                    ApplicationTypeTitle,
                    ApplicationFees
                FROM ApplicationTypes
                ORDER BY ApplicationTypeID;";

            using (SqlConnection connection = new SqlConnection(
                DataAccessSetting.DataBaseSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        applicationTypesTable.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(
                        $"Error loading application types: {ex.Message}");
                }
            }

            return applicationTypesTable;
        }

        // Gets the total number of application types.
        public static int GetApplicationTypeCount()
        {
            string query = @"
                SELECT COUNT(*)
                FROM ApplicationTypes;";

            using (SqlConnection connection = new SqlConnection(
                DataAccessSetting.DataBaseSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    return result != null && result != DBNull.Value
                        ? Convert.ToInt32(result)
                        : 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(
                        $"Error getting application type count: {ex.Message}");

                    return 0;
                }
            }
        }
    }
}