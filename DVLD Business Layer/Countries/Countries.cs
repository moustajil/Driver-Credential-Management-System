using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business_Layer
{
    public class BnCountries
    {
        public static string[] GetAllCountries()
        {
            return DVL_Data_Access_Layer.Countries.GetAllCountries();
        }


        public static string GetCountryNameByCountryID(int countryID) {
            return DVL_Data_Access_Layer.Countries.GetCountry(countryID);
        }
    }
}
