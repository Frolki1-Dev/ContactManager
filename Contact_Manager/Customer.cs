using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    class Customer : Person
    {
        //constructor
        public Customer(string salutation, string firstName, string lastName, DateTime dateOfBirth, int gender, string title, string email, string status,
            string address, int zipCode, string phonePrivate, string phoneCompany, string fax, string mobile, string city, string country, string companyName, string customerType, string companyContact)
            : base(salutation, firstName, lastName, dateOfBirth, gender, title, email, status, address, zipCode, phonePrivate, phoneCompany, fax, mobile, city, country)
        {
            CompanyName = companyName;
            CustomerType = customerType;
            CompanyContact = companyContact;
        }

        //Properties
        public string CompanyName { get; set; }
        public string CustomerType { get; set; }
        public string CompanyContact { get; set; }
    }
}