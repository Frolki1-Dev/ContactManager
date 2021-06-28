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
        protected string table;

        public List<Dictionary<string, dynamic>> selectAll(string columns = "ROWID, *")
        {
            List<Dictionary<string, dynamic>> result = new List<Dictionary<string, dynamic>>();
            List<string> cols = new List<string>();

            using (SqliteConnection connection = DatabaseConnection.getSqliteConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT "+columns+" FROM " + this.getTable();

                SqliteDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return result;
                }

                // Read out the data
                while(reader.Read())
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

        public bool insert()
        {
            try
            {
                DatabaseConnection.openDatabaseConnection();
                DatabaseConnection.startTransaction();

                DatabaseConnection.commit();
            } catch
            {
                DatabaseConnection.rollback();
            } finally
            {
                DatabaseConnection.closeDatabaseConnection();
            }
            return false;
        }

        public bool updateById(int rowId)
        {
            return false;
        }

        /**
         * Set the deleted flag
         */
        public bool delete(int rowId)
        {
            return false;
        }

        /**
         * Get the table name
         */
        protected abstract string getTable();
    }
}
