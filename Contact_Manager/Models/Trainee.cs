﻿using System;

namespace Contact_Manager.Models
{
    [Serializable]
    public class Trainee : Employee
    {
        // constructor
        public Trainee(string salutation, string firstName, string lastName, DateTime dateOfBirth, int gender,
            string title, string email, bool status, string address, int zipCode, string phonePrivate, string phoneCompany,
            string fax, string mobile, string city, string country,
            int employeeNumber, string departement, string ahv, string nationality, DateTime entryDate,
            DateTime exitDate, int loe, string role, int managementLevel,
            int CurrentTraineeYear, int MaxTraineeYear)
            : base(salutation, firstName, lastName, dateOfBirth, gender, title, email, status, address, zipCode,
                  phonePrivate, phoneCompany, fax, mobile, city, country, departement, ahv, nationality,
                  entryDate, exitDate, loe, role, managementLevel)
        {
            CurrentTraineeYear = currentTraineeYear;
            MaxTraineeYear = maxTraineeYear;
        }

        // variables
        public int currentTraineeYear { get; set; }
        public int maxTraineeYear { get; set; }

        // methods
    }
}
