using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager.Authentication;
using Contact_Manager.Interfaces;

namespace Contact_Manager.Models
{
    /**
     * User object
     */
    [Serializable]
    public class User : IIdentifier
    {
        public int Id { get; set; }
        public string Username { get; set; }

        private string _password;

        public string Password
        {
            get => _password;
            set => _password = PasswordHasher.HashString(value);
        }

        public bool Active { get; set; }
        public bool IsAdmin { get; set; }

        public bool Deleted { get; set; }

        public User(string username, string password, bool active, bool isAdmin)
        {
            Username = username;
            Password = password;
            Active = active;
            IsAdmin = isAdmin;
        }
    }
}