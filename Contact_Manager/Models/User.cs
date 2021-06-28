using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager.Models
{
    class User : Model
    {
        public int id { get; internal set; }
        public string username { get; set; }
        public string password { get; internal set; }
        public bool active { get; internal set; }
        public bool is_admin { get; internal set; }

        public void getByUsername(string username)
        {
            using (SqliteConnection connection = DatabaseConnection.getSqliteConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT ROWID, * FROM logins WHERE username = @username";

                command.Parameters.AddWithValue("@username", username);

                SqliteDataReader reader = command.ExecuteReader();
 
                if(!reader.HasRows)
                {
                    return;
                }

                reader.Read();
                this.id = reader.GetInt32(0);
                this.username = reader.GetString(1);
                this.password = reader.GetString(2);
                this.active = reader.GetBoolean(3);
                this.is_admin = reader.GetBoolean(4);
            }
        }

        protected override string getTable()
        {
            return "logins";
        }
    }
}
