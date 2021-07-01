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

        private static Users UserCollection = new Users();

        public static void AddModel(string type, dynamic data)
        {
            switch (type)
            {
                case Users:
                    UserCollection.Add((User)data);
                    break;
            }
        }

        public static void LoadAll(string type)
        {
            switch (type)
            {
                case Users:
                    ReadBinaryFile(type);
                    break;
            }
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
                    UserCollection = (Users) obj;
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
                    formatter.Serialize(stream, UserCollection);
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
            return UserCollection;
        }
    }
}
