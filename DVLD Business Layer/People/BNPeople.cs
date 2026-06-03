using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVL_Data_Access_Layer;

namespace DVLD_Business_Layer
{
    namespace DVLD_Business_Layer
    {
        public class BNPeople
        {
            public int PersonID { get; set; }
            public string NationalID { get; set; }
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string ThirdName { get; set; }
            public string LastName { get; set; }
            public System.DateTime DateOfBirth { get; set; }
            public byte Gender { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public int NationalityCountryID { get; set; }
            public string ImagePath { get; set; }

            public BNPeople()
            {
                PersonID = -1;
                NationalID = "";
                FirstName = "";
                SecondName = "";
                ThirdName = "";
                LastName = "";
                Address = "";
                Phone = "";
                Email = "";
                ImagePath = "";
                NationalityCountryID = -1;
                Gender = 0;
                DateOfBirth = System.DateTime.Now;
            }

            public bool AddNewPerson()
            {
                return DVL_Data_Access_Layer.People.BDAPeople.AddPerson(
                    NationalID,
                    FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    DateOfBirth,
                    Gender,
                    Address,
                    Phone,
                    Email,
                    NationalityCountryID,
                    ImagePath
                );
            }

            public bool UpdatePerson()
            {
                return DVL_Data_Access_Layer.People.BDAPeople.UpdatePerson(
                    PersonID,
                    NationalID,
                    FirstName,
                    SecondName,
                    ThirdName,
                    LastName,
                    DateOfBirth,
                    Gender,
                    Address,
                    Phone,
                    Email,
                    NationalityCountryID,
                    ImagePath
                );
            }

            public static bool DeletePerson(int PersonID)
            {
                return DVL_Data_Access_Layer.People.BDAPeople.DeletePerson(PersonID);
            }

            public static System.Data.DataTable GetAllPeople()
            {
                return DVL_Data_Access_Layer.People.BDAPeople.GetAllPeople();
            }

            public static BNPeople Find(int PersonID)
            {
                string NationalID = "";
                string FirstName = "";
                string SecondName = "";
                string ThirdName = "";
                string LastName = "";
                string Address = "";
                string Phone = "";
                string Email = "";
                string ImagePath = "";
                int NationalityCountryID = -1;
                byte Gender = 0;
                System.DateTime DateOfBirth = System.DateTime.Now;

                bool Found =
                    DVL_Data_Access_Layer.People.BDAPeople.FindPersonByID(
                        PersonID,
                        ref NationalID,
                        ref FirstName,
                        ref SecondName,
                        ref ThirdName,
                        ref LastName,
                        ref DateOfBirth,
                        ref Gender,
                        ref Address,
                        ref Phone,
                        ref Email,
                        ref NationalityCountryID,
                        ref ImagePath
                    );

                if (Found)
                {
                    BNPeople Person = new BNPeople();

                    Person.PersonID = PersonID;
                    Person.NationalID = NationalID;
                    Person.FirstName = FirstName;
                    Person.SecondName = SecondName;
                    Person.ThirdName = ThirdName;
                    Person.LastName = LastName;
                    Person.DateOfBirth = DateOfBirth;
                    Person.Gender = Gender;
                    Person.Address = Address;
                    Person.Phone = Phone;
                    Person.Email = Email;
                    Person.NationalityCountryID = NationalityCountryID;
                    Person.ImagePath = ImagePath;

                    return Person;
                }

                return null;
            }


            public static int NumbersOfPeople()
            {
                return DVL_Data_Access_Layer.People.BDAPeople.CountsOfPeopls();
            }
        }
    }
}
