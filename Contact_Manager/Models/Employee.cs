using System;

namespace Contact_Manager.Models
{
    /**
     * Employee object
     */
    [Serializable]
    public class Employee : Person
    {
        // constructor
        public Employee(string salutation, string firstName, string lastName, DateTime dateOfBirth, int gender,
            string title, string email, bool status, string address, int zipCode, string phonePrivate,
            string phoneCompany,
            string fax, string mobile, string city, string country,
            string departement, string ahv, string nationality, DateTime entryDate,
            DateTime exitDate, int loe, string role, int managementLevel)
            : base(salutation, firstName, lastName, dateOfBirth, gender, title, email, status, address, zipCode,
                phonePrivate, phoneCompany, fax, mobile, city, country)
        {
            Departement = departement;
            Ahv = ahv;
            Nationality = nationality;
            EntryDate = entryDate;
            ExitDate = exitDate;
            Loe = loe;
            Role = role;
            ManagementLevel = managementLevel;
        }

        // properties
        public string Departement { get; set; }
        public string Ahv { get; set; }
        public string Nationality { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
        public int Loe { get; set; }
        public string Role { get; set; }
        public int ManagementLevel { get; set; }
    }
}