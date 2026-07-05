using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer.LicenseeClass
{
    class BNLicenseClass
    {
        public static DataTable GetAllClassNameOfLicense()
        {
            return DVL_Data_Access_Layer.LicenseClasses.GetAllClassNames();
        }
    }
}
