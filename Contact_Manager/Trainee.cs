using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    class Trainee : Employee
    {
        // constructor
        public Trainee(string salutation, string firstName, string lastName, DateTime dateOfBirth, int gender,
            string title, string email, string status, string address, int zipCode, string phonePrivate, string phoneCompany,
            string fax, string mobile, string city, string country,
            int employeeNumber, string departement, string password, string ahv, string nationality, DateTime entryDate,
            DateTime exitDate, int loe, string role, int managementLevel,
            int CurrentTraineeYear, int MaxTraineeYear)
            : base(salutation, firstName, lastName, dateOfBirth, gender, title, email, status, address, zipCode,
                  phonePrivate, phoneCompany, fax, mobile, city, country, employeeNumber, departement, password, ahv, nationality,
                  entryDate, exitDate, loe, role, managementLevel)
        {
            CurrentTraineeYear = currentTraineeYear;
            MaxTraineeYear = maxTraineeYear;
        }

        // variables
        public int currentTraineeYear { get; set; }
        public int maxTraineeYear { get; set; }

        // methods
        // hier erfolgt der Speichervorgang in das ensprechende JSON-File
    }
}
