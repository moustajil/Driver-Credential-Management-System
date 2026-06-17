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
    }
}