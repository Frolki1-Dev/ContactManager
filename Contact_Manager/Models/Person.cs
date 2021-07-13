﻿using System;

namespace Contact_Manager.Models
{
    class Person
    {
        // variables

        // constructor
        public Person(string salutation, string firstName, string lastName, DateTime dateOfBirth, int gender, string title, string email, string status,
            string address, int zipCode, string phonePrivate, string phoneCompany, string fax, string mobile, string city, string country)
        {
            Salutation = salutation;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Title = title;
            Email = email;
            Status = status;
            Address = address;
            ZipCode = zipCode;
            City = city;
            PhonePrivate = phonePrivate;
            PhoneCompany = phoneCompany;
            Fax = fax;
            Mobile = mobile;
            Country = country;
        }

        // properties
        public int Id { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string PhonePrivate { get; set; }
        public string PhoneCompany { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool Deleted { get; set; }

        // methods
        // hier erfolgt der Speichervorgang in das ensprechende JSON-File
    }
}
