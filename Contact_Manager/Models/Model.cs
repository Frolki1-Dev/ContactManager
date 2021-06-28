using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager.Models
{
    abstract class Model
    {
        /**
         * Select all rows in the table
         */
        public List<Dictionary<string, dynamic>> selectAll(string columns = "ROWID, *")
        {
            string sql = "SELECT " + columns + " FROM " + this.getTable();

            return getResult(sql);
        }

        /**
         * Make a SELECT statement against the database
         */
        public List<Dictionary<string, dynamic>> select(string columns = "ROWID, *", string appendSql = "", Dictionary<string, dynamic> parameters = null)
        {
            string sql = "SELECT " + columns + " FROM " + this.getTable() + " " + appendSql;

            if(parameters == null)
            {
                return getResult(sql);
            }

            return getResult(sql, parameters);
        }

        private List<Dictionary<string, dynamic>> getResult(string sql, Dictionary<string, dynamic> parameters = null)
        {
            List<Dictionary<string, dynamic>> result = new List<Dictionary<string, dynamic>>();

            using (SqliteConnection connection = DatabaseConnection.getSqliteConnection())
            {
                // Prepare everything for the command
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = sql;

                // Checks if parameters is not null
                if(parameters != null)
                {
                    // Add parameters to the sql command
                    foreach(KeyValuePair<string, dynamic> p in parameters)
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
         * Get the table name
         */
        protected abstract string getTable();
    }
}
