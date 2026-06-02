using System;
using System.Data;
using DVLD_DataAccess_Layer;

namespace DVLD_Business_Layer.Users
{
    public class BnPeopleManagement
    {
        ClsPeopleManagement _peopleDal = new ClsPeopleManagement();

        // GET ALL PEOPLE
        public DataTable GetAllPeople()
        {
            return _peopleDal.GetAllPeople();
        }

        // ADD PERSON (with basic validation)
        public bool AddPerson(
            string nationalId,
            string firstName,
            string secondName,
            string thirdName,
            string lastName,
            DateTime dateOfBirth,
            string gender,
            string address,
            string phone,
            string email,
            int nationalityCountryId,
            string imagePath)
        {
            if (string.IsNullOrWhiteSpace(nationalId))
                throw new Exception("National ID is required");

            if (string.IsNullOrWhiteSpace(firstName))
                throw new Exception("First name is required");

            if (dateOfBirth > DateTime.Now)
                throw new Exception("Invalid date of birth");

            return _peopleDal.AddPerson(
                nationalId,
                firstName,
                secondName,
                thirdName,
                lastName,
                dateOfBirth,
                gender,
                address,
                phone,
                email,
                nationalityCountryId,
                imagePath
            );
        }

        // UPDATE PERSON
        public bool UpdatePerson(
            int personId,
            string nationalId,
            string firstName,
            string secondName,
            string thirdName,
            string lastName,
            DateTime dateOfBirth,
            string gender,
            string address,
            string phone,
            string email,
            int nationalityCountryId,
            string imagePath)
        {
            if (personId <= 0)
                throw new Exception("Invalid Person ID");

            return _peopleDal.UpdatePerson(
                personId,
                nationalId,
                firstName,
                secondName,
                thirdName,
                lastName,
                dateOfBirth,
                gender,
                address,
                phone,
                email,
                nationalityCountryId,
                imagePath
            );
        }

        // DELETE PERSON
        public bool DeletePerson(int personId)
        {
            if (personId <= 0)
                throw new Exception("Invalid Person ID");

            return _peopleDal.DeletePerson(personId);
        }
    }
}