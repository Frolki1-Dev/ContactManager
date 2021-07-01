using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contact_Manager.Collections;
using Contact_Manager.Models;

namespace Contact_Manager
{
    /**
     * Handles all data
     */
    sealed class DataContainer
    {
        /**
         * All possible data sources as const
         */
        public const string Users = "users";
        public const string Customers = "customers";
        public const string Employees = "employees";
        public const string Trainees = "trainees";

        private static Users _userCollection = new Users();
        private static Customers _customerCollection = new Customers();
        private static Employees _employeeCollection = new Employees();
        private static Trainees _traineeCollection = new Trainees();

        public static void AddModel(string type, dynamic data)
        {
            switch (type)
            {
                case Users:
                    _userCollection.Add((User)data);
                    break;
                case Customers:
                    _customerCollection.Add((Customer)data);
                    break;
                case Employees:
                    _employeeCollection.Add((Employee)data);
                    break;
                case Trainees:
                    _traineeCollection.Add((Trainee)data);
                    break;
            }
        }

        public static void LoadAll(string type)
        {
            ReadBinaryFile(type);
        }

        private static void ReadBinaryFile(string type)
        {
            string file = Helper.GetApplicationDataPath(type + ".dat");

            // Check if file exists
            if (!File.Exists(file))
            {
                throw new FileNotFoundException("The dat file " + file + " was not founded.");
            }

            // Create binary formatter
            BinaryFormatter formatter = new BinaryFormatter();

            // Read the file
            FileStream fs = File.Open(file, FileMode.Open);

            // Deserialize
            object obj = formatter.Deserialize(fs);
            fs.Flush();
            fs.Close();
            fs.Dispose();

            switch (type)
            {
                case Users:
                    _userCollection = (Users) obj;
                    break;
                case Customers:
                    _customerCollection = (Customers) obj;
                    break;
                case Employees:
                    _employeeCollection = (Employees) obj;
                    break;
                case Trainees:
                    _traineeCollection = (Trainees) obj;
                    break;
            }
        }

        private static void WriteBinaryFile(string type)
        {
            string file = Helper.GetApplicationDataPath(type + ".dat");

            // Check if file exists
            if (!File.Exists(file))
            {
                throw new FileNotFoundException("The dat file " + file + " was not founded.");
            }

            // Create file stream
            Stream stream = File.OpenWrite(file);

            // Create binary formatter
            BinaryFormatter formatter = new BinaryFormatter();

            // Serialize
            switch (type)
            {
                case Users:
                    formatter.Serialize(stream, _userCollection);
                    break;
                case Customers:
                    formatter.Serialize(stream, _customerCollection);
                    break;
                case Employees:
                    formatter.Serialize(stream, _employeeCollection);
                    break;
                case Trainees:
                    formatter.Serialize(stream, _traineeCollection);
                    break;
            }

            // Clean up
            stream.Flush();
            stream.Close();
            stream.Dispose();
        }

        public static void SaveList(string type)
        {
            WriteBinaryFile(type);
        }

        public static void SaveAll()
        {

        }

        public static Users GetUserCollection()
        {
            return _userCollection;
        }

        public static Customers GetCustomerCollection()
        {
            return _customerCollection;
        }

        public static Employees GetEmployeeCollection()
        {
            return _employeeCollection;
        }

        public static Trainees GetTraineeCollection()
        {
            return _traineeCollection;
        }
    }
}
