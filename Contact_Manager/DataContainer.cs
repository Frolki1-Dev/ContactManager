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

        /**
         * Add object to the given type in the collection
         */
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

        /**
         * Load all data from the given type
         */
        public static void LoadAll(string type)
        {
            ReadBinaryFile(type);
        }

        /**
         * Read out the binary data and convert it to the given type
         */
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
            object obj = new object();

            if (fs.Length > 0)
            {
                 obj = formatter.Deserialize(fs);
            }

            fs.Flush();
            fs.Close();
            fs.Dispose();

            switch (type)
            {
                case Users:
                    _userCollection = (Users)obj;
                    break;
                case Customers:
                    if (obj.GetType().ToString() == "System.Object")
                    {
                        _customerCollection = new Customers();
                        break;
                    }
                    _customerCollection = (Customers) obj;
                    break;
                case Employees:
                    if (obj.GetType().ToString() == "System.Object")
                    {
                        _employeeCollection = new Employees();
                        break;
                    }
                    _employeeCollection = (Employees) obj;
                    break;
                case Trainees:
                    if (obj.GetType().ToString() == "System.Object")
                    {
                        _traineeCollection = new Trainees();
                        break;
                    }
                    _traineeCollection = (Trainees) obj;
                    break;
            }
        }

        /**
         * Save / Write the binary file of the given type
         */
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

        /**
         * Save a collection to the filesystem
         */
        public static void SaveList(string type)
        {
            WriteBinaryFile(type);
        }

        /**
         * Delete the passed resource (Set deleted flag to true)
         */
        public static void Delete(dynamic data)
        {
            if (data.GetType() == typeof(User))
            {
                _userCollection.Delete(((User)data).Id);
            } else if (data.GetType() == typeof(Trainee))
            {
               _traineeCollection.Delete(((Trainee)data).Id);
            } else if (data.GetType() == typeof(Customer))
            {
                _customerCollection.Delete(((Customer) data).Id);
            } else if (data.GetType() == typeof(Employee))
            {
               _employeeCollection.Delete(((Employee) data).Id);
            }
            else
            {
                throw new InvalidDataException("Given data object is an unknown object type!");
            }
        }

        /**
         * Update the passed resource
         */
        public static void Update(dynamic data)
        {
            if (data.GetType() == typeof(User))
            {
                _userCollection.Edit((User)data);
            }
            else if (data.GetType() == typeof(Trainee))
            {
                _traineeCollection.Edit((Trainee)data);
            }
            else if (data.GetType() == typeof(Customer))
            {
                _customerCollection.Edit((Customer) data);
            }
            else if (data.GetType() == typeof(Employee))
            {
                _employeeCollection.Edit((Employee) data);
            }
            else
            {
                throw new InvalidDataException("Given data object is an unknown object type!");
            }
        }

        /**
         * Get all active user
         */
        public static Users GetUserCollection()
        {
            Users temp = _userCollection;

            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Deleted)
                {
                    temp.RemoveAt(i);
                }
            }

            return temp;
        }

        /**
         * Get all active customer
         */
        public static Customers GetCustomerCollection()
        {
            Customers temp = _customerCollection;

            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Deleted)
                {
                    temp.RemoveAt(i);
                }
            }

            return temp;
        }

        /**
         * Get all active employee
         */
        public static Employees GetEmployeeCollection()
        {
            Employees temp = _employeeCollection;

            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Deleted)
                {
                    temp.RemoveAt(i);
                }
            }

            return temp;
        }

        /**
         * Get all active trainees
         */
        public static Trainees GetTraineeCollection()
        {
            Trainees temp = _traineeCollection;

            for (int i = 0; i < temp.Count; i++)
            {
                if (temp[i].Deleted)
                {
                    temp.RemoveAt(i);
                }
            }

            return temp;
        }
    }
}