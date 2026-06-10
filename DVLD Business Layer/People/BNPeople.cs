

using System;

namespace DVLD_Business_Layer
{
    namespace DVLD_Business_Layer
    {
        public class BNPeople
        {
            private string nationalityNumber;
            private string fourthName;
            private DateTime birthDate;
            private string phoneNumber;
            private string emailText;
            private string country;
            private DateTime birthDate1;
            private int country1;

            public int PersonID { get; set; }
            public string NationalID { get; set; }
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string ThirdName { get; set; }
            public string LastName { get; set; }
            public System.DateTime DateOfBirth { get; set; }
            public int Gender { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public int NationalityCountryID { get; set; }
            public string ImagePath { get; set; }

            private BNPeople()
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

            public BNPeople(
    string nationalID,
    string firstName,
    string secondName,
    string thirdName,
    string lastName,
    DateTime dateOfBirth,
    int gender,
    string address,
    string phone,
    string email,
    int nationalityCountryID,
    string imagePath)
            {
                NationalID = nationalID;
                FirstName = firstName;
                SecondName = secondName;
                ThirdName = thirdName;
                LastName = lastName;
                DateOfBirth = dateOfBirth;
                Gender = gender;
                Address = address;
                Phone = phone;
                Email = email;
                NationalityCountryID = nationalityCountryID;
                ImagePath = imagePath;
            }

            public BNPeople(string nationalityNumber, string firstName, string secondName, string thirdName, string fourthName, DateTime birthDate, int gender, string phoneNumber, string emailText, string country, string imagePath)
            {
                this.nationalityNumber = nationalityNumber;
                FirstName = firstName;
                SecondName = secondName;
                ThirdName = thirdName;
                this.fourthName = fourthName;
                this.birthDate = birthDate;
                Gender = gender;
                this.phoneNumber = phoneNumber;
                this.emailText = emailText;
                this.country = country;
                ImagePath = imagePath;
            }

            public BNPeople(string nationalityNumber, string firstName, string secondName, string thirdName, string fourthName, DateTime birthDate1, int gender, string phoneNumber, string emailText, int country1, string imagePath)
            {
                this.nationalityNumber = nationalityNumber;
                FirstName = firstName;
                SecondName = secondName;
                ThirdName = thirdName;
                this.fourthName = fourthName;
                this.birthDate1 = birthDate1;
                Gender = gender;
                this.phoneNumber = phoneNumber;
                this.emailText = emailText;
                this.country1 = country1;
                ImagePath = imagePath;
            }

            public int AddNewPerson()
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

            public static bool checkNationaNumber(string nNumber)
            {
                return DVL_Data_Access_Layer.People.BDAPeople.FindNationaNumber(nNumber);
            }
        }
    }
}
