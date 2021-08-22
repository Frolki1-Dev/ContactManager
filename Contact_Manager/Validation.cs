using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager
{
    /**
     * Handles our own exception type
     */
    class ValidationException : Exception
    {
        public ValidationException(string message) : base(message: message)
        {

        }
    }
    class Validation
    {
        /**
         * Check if the email is valid
         */
        public static void ValidateEmail(string email, string exceptionMessage = "Die E-Mailadresse ist nicht gültig")
        {
            // source: https://stackoverflow.com/questions/5342375/regex-email-validation / https://docs.microsoft.com/en-us/dotnet/api/system.net.mail.mailaddress?redirectedfrom=MSDN&view=net-5.0
            try
            {
                new MailAddress(email);
            }
            catch (FormatException)
            {
                throw new ValidationException(exceptionMessage);
            }
        }

        public static void ValidatePhone(string number, string exceptionMessage = "Die Nummer ist nicht gültig!")
        {
            // Trim the input
            number = String.Concat(number.Where(c => !Char.IsWhiteSpace(c)));

            // Check with 0041 00 000 00 00
            if (number.Substring(0, 2) == "00" && (number.Length == 13 || number.Length == 14))
            {
                return;
            }

            // Check with +41 00 000 00 00
            if (number.Substring(0, 1) == "+" && (number.Length == 12 || number.Length == 13))
            {
                return;
            }

            // Check with 000 000 00 00
            if (number.Length == 10)
            {
                return;
            }

            throw new ValidationException(exceptionMessage + "\nFormate:\n0041 00 000 00 00\n +41 00 000 00 00\n000 000 00 00");
        }

        public static void ValidateZipCode(int zipCode, string exceptionMessage = "Die Postleitzahl ist nicht gültig!")
        {
            if (zipCode < 1000 || zipCode > 9999)
            {
                throw new ValidationException(exceptionMessage);
            }
        }

        public static void Required(TextBox field, string exceptionMessage)
        {
            if (field.Text.Length < 1)
            {
                throw new ValidationException(exceptionMessage);
            }
        }

        public static void Required(string field, string exceptionMessage)
        {
            if (field.Length < 1)
            {
                throw new ValidationException(exceptionMessage);
            }
        }
    }
}
