using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    class Customer
    {
        public Customer(string companyname, string c_address, int c_zipcode, string c_city, string c_name, string c_surname, int c_phonenumber, string c_mail)
        {
            Companyname = companyname;
            C_Address = c_address;
            C_Zipcode = c_zipcode;
            C_City = c_city;
            C_Name = c_name;
            C_Surname = c_surname;
            C_Phonenumber = c_phonenumber;
            C_Mail = c_mail;


        }

        public string Companyname { get; set; }

        public string C_Address { get; set; }

        public int C_Zipcode { get; set; }

        public string C_City { get; set; }

        public string C_Name { get; set; }

        public string C_Surname { get; set; }

        public int C_Phonenumber { get; set; }

        public string C_Mail { get; set; }






    }

}
