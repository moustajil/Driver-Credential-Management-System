using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_Data_Access_Layer.ApplicationTestType
{
    public class DBAApplicationTestType
    {

        // Get All Application Test Types
        public static DataTable GetAllApplicationTestType()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM TestTypes;";

            using (SqlConnection connection = new SqlConnection(
                DataAccessSetting.DataBaseSetting.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                        Console.WriteLine(
                            $"Error while loading test types: {ex.Message}"
                        );
                    }
                }
            }

            return dt;
        }


        // Get Test Type By Application Test Type ID
        public static DataTable GetApplicationTestType(int TestTypeID) {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(DataAccessSetting.DataBaseSetting.ConnectionString))
            {
                string query = @"
            SELECT *
            FROM TestTypes
            WHERE TestTypeID = @TestTypeID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@TestTypeID",
                        SqlDbType.Int
                    ).Value = TestTypeID;

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
                        Console.WriteLine(
                            $"Error finding application type: {ex.Message}"
                        );
                    }
                }
            }

            return dt;
        }

    }
}
