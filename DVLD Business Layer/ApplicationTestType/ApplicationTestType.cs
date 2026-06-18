
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer.ApplicationTestType
{
    public class BNApplicationTestType
    {
        public static DataTable GetAllApplicationTestType()
        {
            return DVL_Data_Access_Layer.ApplicationTestType.DBAApplicationTestType.GetAllApplicationTestType();
        }

        public static DataTable GetApplicationTestTypeByID(int testTypeID) {
            return DVL_Data_Access_Layer.ApplicationTestType.DBAApplicationTestType.GetApplicationTestType(testTypeID);
        }


    }
}
