using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    class Person
    {
        // variables

        // constructor
        public Person(string salutation, string first_name, string last_name, string date_of_birth, int gender, string title, string email, string status, string address, int zip_code, int phone_private, int phone_company, int fax, int mobile, string city, string country)
        {
            Salutation = salutation;
            First_name = first_name;
            Last_name = last_name;
            Date_of_birth = date_of_birth;
            Gender = gender;
            Title = title;
            Email = email;
            Status = status;
            Address = address;
            Zip_code = zip_code;
            City = city;
            Phone_private = phone_private;
            Phone_company = phone_company;
            Fax = fax;
            Mobile = mobile;
            Country = country;
        }

        // properties
        public string Salutation { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Date_of_birth { get; set; }
        public int Gender { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public int Zip_code { get; set; }
        public int Phone_private { get; set; }
        public int Phone_company { get; set; }
        public int Fax { get; set; }
        public int Mobile { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        // methods

    }
}
