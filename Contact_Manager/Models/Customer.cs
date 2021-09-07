using System;
using System.Collections.Generic;

namespace Contact_Manager.Models
{
    /**
     * Customer object
     */
    [Serializable]
    public class Customer : Person
    {
        //constructor
        public Customer(string salutation, string firstName, string lastName, DateTime dateOfBirth, int gender,
            string title, string email, bool status,
            string address, int zipCode, string phonePrivate, string phoneCompany, string fax, string mobile,
            string city, string country, string companyName, string customerType, List<CustomerNotes> notes)
            : base(salutation, firstName, lastName, dateOfBirth, gender, title, email, status, address, zipCode,
                phonePrivate, phoneCompany, fax, mobile, city, country)
        {
            CompanyName = companyName;
            CustomerType = customerType;
            Notes = notes;
        }

        //Properties
        public string CompanyName { get; set; }
        public string CustomerType { get; set; }

        public List<CustomerNotes> Notes { get; set; }
    }
}