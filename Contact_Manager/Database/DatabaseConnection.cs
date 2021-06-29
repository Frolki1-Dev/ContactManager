using System;
using System.IO;
using Contact_Manager.Authentication;
using Microsoft.Data.Sqlite;

namespace Contact_Manager.Database
{
    class DatabaseConnection
    {
        private static SqliteConnection _sqliteConnection;

        private static SqliteTransaction _sqliteTransaction;

        public static void BuildDatabaseConnection(string databaseFile)
        {
            // Check if file exists
            if(!File.Exists(databaseFile))
            {
                throw new FileNotFoundException("The database file " + databaseFile + " doesn't exists.");
            }

            Console.WriteLine("Data Source=" + databaseFile + ";Version=3");

            // Create the datasource
            _sqliteConnection = new SqliteConnection(@"Data Source=" + databaseFile);
        }

        /**
         * Closes the database connection
         */
        public static void CloseDatabaseConnection()
        {
            _sqliteConnection.Close();
        }

        public static void OpenDatabaseConnection()
        {
            _sqliteConnection.Open();
        }

        public static void StartTransaction()
        {
            _sqliteTransaction = _sqliteConnection.BeginTransaction();
        }

        public static void Commit()
        {
            _sqliteTransaction.Commit();
        }

        public static void Rollback()
        {
            _sqliteTransaction.Rollback();
        }

        public static int EffectedStatement(string sql)
        {
            var command = _sqliteConnection.CreateCommand();
            command.CommandText = sql;
            // TODO: Add parameter
            return command.ExecuteNonQuery();
        }

        /**
         * Checks if we have an active connection to our SQLite database
         */
        public static bool HasActiveConnection()
        {
            // Is the connection null?
            if(_sqliteConnection == null)
            {
                return false;
            }

            return _sqliteConnection.GetType() == typeof(SqliteConnection);
        }

        public static SqliteConnection GetSqliteConnection()
        {
            return _sqliteConnection;
        }

        public static void BuildDatabase(string databaseFile, string username, string password)
        {
            // Check if the file exists
            if(File.Exists(databaseFile))
            {
                // The dark force should not try to overwrite the database file
                throw new FileLoadException("The database file " + databaseFile + " already exists!");
            }

            string addUserSql = "INSERT INTO logins (Username, Password, Active, IsAdmin) VALUES (@username, @password, 1, 1);";

            FileStream file = File.Create(databaseFile);
            file.Close();

            // Populate the database with the structure
            BuildDatabaseConnection(databaseFile);

            using (SqliteConnection connection = _sqliteConnection) {
                connection.Open();
                var command = _sqliteConnection.CreateCommand();
                command.CommandText = GetDatabaseSchema() + addUserSql;

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", PasswordHasher.HashString(password));

                command.ExecuteNonQuery();
            }
        }

        private static string GetDatabaseSchema()
        {
            return @"
                CREATE TABLE logins (
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Active INTEGER DEFAULT 0 NOT NULL,
                    IsAdmin INTEGER DEFAULT 0 NOT NULL
                );

                CREATE TABLE customers (
	                Salutation TEXT,
	                FirstName TEXT,
	                LastName TEXT,
	                Gender INTEGER DEFAULT 1 NOT NULL,
	                Title TEXT,
	                Email TEXT,
	                Status INTEGER DEFAULT 1 NOT NULL,
	                Deleted INTEGER DEFAULT 0 NOT NULL,
	                CompanyName TEXT,
	                CustomerType TEXT(1) DEFAULT A NOT NULL,
	                CompanyContact TEXT,
	                Cid INTEGER DEFAULT NULL
                );
                
                CREATE TABLE contacts (
	                Street TEXT,
	                ZipCode TEXT,
	                PhonePrivate TEXT,
	                PhoneCompany TEXT,
	                Fax TEXT,
	                Mobile TEXT,
	                Email TEXT, 
                    Place TEXT, 
                    Country TEXT(2) DEFAULT CH NOT NULL
                );

                CREATE TABLE employees (
	                Department TEXT,
	                AhvNumber TEXT(16),
	                Nationality TEXT(2),
	                EntryDate TEXT,
	                ExitDate TEXT,
	                Loe INTEGER DEFAULT 100 NOT NULL,
	                'Role' TEXT,
                    ManagementLevel INTEGER DEFAULT 0 NOT NULL,
                    IsTrainee INTEGER DEFAULT 0 NOT NULL,
                    Salutation TEXT,
	                FirstName TEXT,
                    LastName TEXT,
	                DateOfBirth TEXT,
                    Gender INTEGER DEFAULT 1 NOT NULL,
                    Title TEXT,
	                Status INTEGER DEFAULT 1,
	                Deleted INTEGER DEFAULT 0, 
                    Cid INTEGER
                );
            ";
        }
    }
}
