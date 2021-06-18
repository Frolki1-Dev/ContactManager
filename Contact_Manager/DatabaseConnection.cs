using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    class DatabaseConnection
    {
        private static SqliteConnection sqliteConnection;

        public static void buildDatabaseConnection(string databaseFile)
        {
            // Check if file exists
            if(!File.Exists(databaseFile))
            {
                throw new FileNotFoundException("The database file " + databaseFile + " doesn't exists.");
            }

            Console.WriteLine("Data Source=" + databaseFile + ";Version=3");

            // Create the datasource
            sqliteConnection = new SqliteConnection(@"Data Source=" + databaseFile);
        }

        /**
         * Closes the database connection
         */
        public static void closeDatabaseConnection()
        {
            sqliteConnection.Close();
        }

        /**
         * Checks if we have an active connection to our SQLite database
         */
        public static bool hasActiveConnection()
        {
            // Is the connection null?
            if(sqliteConnection == null)
            {
                return false;
            }

            return sqliteConnection.GetType() == typeof(SqliteConnection);
        }

        public static void buildDatabase(string databaseFile)
        {
            // Check if the file exists
            if(File.Exists(databaseFile))
            {
                // The dark force should not try to overwrite the database file
                throw new FileLoadException("The database file " + databaseFile + " already exists!");
            }

            FileStream file = File.Create(databaseFile);
            file.Close();

            // Populate the database with the structure
            buildDatabaseConnection(databaseFile);

            using (SqliteConnection connection = sqliteConnection) {
                connection.Open();
                var command = sqliteConnection.CreateCommand();
                command.CommandText = getDatabaseSchema();
                command.ExecuteNonQuery();
            }
        }

        private static string getDatabaseSchema()
        {
            return @"
                CREATE TABLE customers (
	                salutation TEXT,
	                first_name TEXT,
	                last_name TEXT;
	                gender INTEGER DEFAULT 1 NOT NULL,
	                title TEXT,
	                email TEXT,
	                status INTEGER DEFAULT 1 NOT NULL,
	                deleted INTEGER DEFAULT 0 NOT NULL,
	                company_name TEXT,
	                customer_type TEXT(1) DEFAULT A NOT NULL,
	                company_contact TEXT,
	                cid INTEGER DEFAULT NULL
                );
                
                CREATE TABLE contacts (
	                street TEXT,
	                zip_code TEXT,
	                phone_private TEXT,
	                phone_company TEXT,
	                fax TEXT,
	                mobile TEXT,
	                email TEXT, 
                    place TEXT, 
                    country TEXT(2) DEFAULT CH NOT NULL
                );

                CREATE TABLE employees (
	                department TEXT,
	                password TEXT,
	                can_login INTEGER DEFAULT 1 NOT NULL,
	                ahv_number TEXT(16),
	                nationality TEXT(2),
	                entry_date TEXT,
	                exit_date TEXT,
	                loe INTEGER DEFAULT 100 NOT NULL,
	                'role' TEXT,
                    management_level INTEGER DEFAULT 0 NOT NULL,
                    is_trainee INTEGER DEFAULT 0 NOT NULL,
                    salutation TEXT,
	                first_name TEXT,
                    last_name TEXT,
	                date_of_birth TEXT,
                    gender INTEGER DEFAULT 1 NOT NULL,
                    title TEXT,
	                status INTEGER DEFAULT 1,
	                deleted INTEGER DEFAULT 0, 
                    cid INTEGER
                );
            ";
        }
    }
}
