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
        public List<Dictionary<string, dynamic>> select(string appendSql = "", Dictionary<string, dynamic> parameters = null, string columns = "ROWID, *")
        {
            string sql = "SELECT " + columns + " FROM " + this.getTable() + " " + appendSql;

            if(parameters == null)
            {
                return getResult(sql.Trim());
            }

            return getResult(sql.Trim(), parameters);
        }

        /**
         * Get the result from the SqliteDataReader. (Only for SELECT statements)
         */
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

        public void insert(List<string> columns, Dictionary<string, dynamic> values)
        {
            // Create the start of the sql
            string sql = "INSERT INTO " + getTable() + " (";

            // Add the columns
            sql += String.Join(",", columns.ToArray()) + ") VALUES (";

            // Add placeholders
            columns.ForEach(delegate (string placeholder)
            {
                sql += "@" + placeholder + ",";
            });

            sql = sql.TrimEnd(',');

            sql += ")";

            int result = effectedRows(sql, values);

            if(result != 1)
            {
                throw new Exception("Couldn't create the resource.");
            }
        }

        /**
         * Delete a resource
         */
        public void deleteById(int id)
        {
            string sql = "DELETE FROM " + getTable() + " WHERE ROWID = @id";

            Dictionary<string, dynamic> value = new Dictionary<string, dynamic>();
            value.Add("@id", id);

            int result = effectedRows(sql, value);

            if(result != 1)
            {
                throw new Exception("Couldn't delete the resource.");
            }
        }

        /**
         * Execute the SQL statement and return the effected rows
         */
        private int effectedRows(string sql, Dictionary<string, dynamic> parameters)
        {
            int result = 0;

            using (SqliteConnection connection = DatabaseConnection.getSqliteConnection())
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

        /**
         * Setting the properties of the model from the dictionary
         */
        protected void setProperties(Dictionary<string, dynamic> properties)
        {
            foreach(KeyValuePair<string, dynamic> property in properties)
            {
                string propertyKey = property.Key;

                // Special case with ROWID
                if(propertyKey.ToLower() == "rowid")
                {
                    propertyKey = "id";
                }

                if(!this.hasProperty(propertyKey))
                {
                    throw new Exception("Unknown property '"+propertyKey+"' tried to set in the model!");
                }

                string stringType = this.GetType().GetProperty(propertyKey).PropertyType.FullName;
                Type type = Type.GetType(stringType);

                this.GetType().GetProperty(propertyKey).SetValue(this, Convert.ChangeType(property.Value, type));
            }
        }

        /**
         * Checks if the property exists in this object/model
         */
        private bool hasProperty(string propertyName)
        {
            return this.GetType().GetProperty(propertyName) != null;
        }

        /**
         * Get the table name
         */
        protected abstract string getTable();
    }
}
