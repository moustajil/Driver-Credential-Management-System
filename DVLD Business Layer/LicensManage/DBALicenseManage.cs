using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer.LicensManage
{
    public class DBALicenseManage
    {
        // Get All Application
        public static DataTable GetallApplicaiton()
        {
            return DVL_Data_Access_Layer.LiceneseManage.BDALicenseManage.GetAllApplication();
        }

        // insert application
        public static int DBBInsertApplication(string className,
     string nationalID,
     string fullName,
     DateTime date)
        {
            return DVL_Data_Access_Layer.LiceneseManage.BDALicenseManage.InsertApplication(className,nationalID,fullName,date);
        }
    }
}
