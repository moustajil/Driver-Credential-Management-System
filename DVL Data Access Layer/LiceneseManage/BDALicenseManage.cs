using DVL_Data_Access_Layer.DataAccessSetting;
using System.Data.SqlClient;
using System;
using System.Data;

namespace DVL_Data_Access_Layer.LiceneseManage
{
    public class BDALicenseManage
    {

        // Get All application
        public static DataTable GetAllApplication()
        {
            DataTable Application = new DataTable();

            SqlConnection connection =
                    new SqlConnection(DataBaseSetting.ConnectionString);

            string query = "select * from LocalDrivingLicenseApplications_View";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Application.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "An error occurred while retrieving license classes.",
                    ex
                );
            }
            finally
            {
                connection.Close();
            }

            return Application;

        }


        // Insert Application
        public static int InsertApplication(
     string className,
     string nationalID,
     string fullName,
     DateTime date)
        {
            int applicationID = -1;

            using (SqlConnection connection =
                   new SqlConnection(DataBaseSetting.ConnectionString))
            {
                string query = @"
            INSERT INTO LocalDrivingLicenseApplications_View
                (ClassName, NationalID, FullName, ApplicationDate)
            VALUES
                (@ClassName, @NationalID, @FullName, @ApplicationDate);

            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@ClassName",
                        SqlDbType.NVarChar,
                        100
                    ).Value = className;

                    command.Parameters.Add(
                        "@NationalID",
                        SqlDbType.NVarChar,
                        20
                    ).Value = nationalID;

                    command.Parameters.Add(
                        "@FullName",
                        SqlDbType.NVarChar,
                        200
                    ).Value = fullName;

                    command.Parameters.Add(
                        "@ApplicationDate",
                        SqlDbType.DateTime
                    ).Value = date;

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            applicationID = Convert.ToInt32(result);
                        }
                    }
                    catch (SqlException)
                    {
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return applicationID;
        }
    }
}
