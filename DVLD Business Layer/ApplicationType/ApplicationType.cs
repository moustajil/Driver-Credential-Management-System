using System.Data;
using DVL_Data_Access_Layer.Application;

namespace DVLD_Business_Layer.ApplicationType
{
    public static class BNApplicationType
    {
        // Gets all application types.
        public static DataTable GetAllApplicationTypes()
        {
            return DBAApplicationType.GetAllApplicationTypes();
        }

        // Gets the total number of application types.
        public static int GetApplicationTypeCount()
        {
            return DBAApplicationType.GetApplicationTypeCount();
        }

        // Find Application Type By ID
        public static DataTable FindApplicatonTypeByID(int id) {
            return DVL_Data_Access_Layer.Application.DBAApplicationType.FindApplicationTypeByID(id);
        }

        // update Application type
        public static bool UpdateApplicationType(int applicationTypeID, string applicationTitle, decimal applicaiotnFees)
        {
            return DVL_Data_Access_Layer.Application.DBAApplicationType.UpdateInfoApplicationType(applicationTypeID, applicationTitle, applicaiotnFees);
        }
    }
}