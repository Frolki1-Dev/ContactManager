using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Contact_Manager.Database
{
    /**
     * Handles SQL statement
     */
    class DatabaseHandler
    {
        /**
         * Runs a SELECT statement against the database
         */
        public static List<Dictionary<string, dynamic>> Select(string sql, Dictionary<string, dynamic> parameters = null)
        {
            return GetResult(sql, parameters);
        }

        /**
         * Runs a UPDATE statement against the database
         */
        public static int Update(string sql, Dictionary<string, dynamic> parameters = null)
        {
            return EffectedRows(sql, parameters);
        }

        /**
         * Runs a DELETE statement against the database
         */
        public static int Delete(string sql, Dictionary<string, dynamic> parameters = null)
        {
            return EffectedRows(sql, parameters);
        }

        /**
         * Runs an INSERT statement against the database
         */
        public static int Insert(string sql, Dictionary<string, dynamic> parameters = null)
        {
            return EffectedRows(sql, parameters);
        }

        /**
         * Get the result from the SqliteDataReader. (Only for SELECT statements)
         */
        private static List<Dictionary<string, dynamic>> GetResult(string sql, Dictionary<string, dynamic> parameters = null)
        {
            List<Dictionary<string, dynamic>> result = new List<Dictionary<string, dynamic>>();

            using (SqliteConnection connection = DatabaseConnection.GetSqliteConnection())
            {
                // Prepare everything for the command
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = sql;

                // Checks if parameters is not null
                if (parameters != null)
                {
                    // Add parameters to the sql command
                    foreach (KeyValuePair<string, dynamic> p in parameters)
                    {
                        command.Parameters.AddWithValue(p.Key, p.Value);
                    }
                }

                // Execute the command
                SqliteDataReader reader = command.ExecuteReader();

                // Checks if the reader has results
                if (!reader.HasRows)
                {
                    return result;
                }

                // Read out the data
                while (reader.Read())
                {
                    Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dict.Add(reader.GetName(i), reader.GetValue(i));
                    }

                    result.Add(dict);
                }
            }

            return result;
        }

        /**
         * Execute the SQL statement and return the effected rows
         */
        private static int EffectedRows(string sql, Dictionary<string, dynamic> parameters)
        {
            int result = 0;

            using (SqliteConnection connection = DatabaseConnection.GetSqliteConnection())
            {
                // Prepare everything for the command
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = sql;

                // Checks if parameters is not null
                if (parameters != null)
                {
                    // Add parameters to the sql command
                    foreach (KeyValuePair<string, dynamic> p in parameters)
                    {
                        command.Parameters.AddWithValue(p.Key, p.Value);
                    }
                }

                result = command.ExecuteNonQuery();
            }

            return result;
        }
    }
}
