using System;
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
        private string _password;

        public User(string username, string password, bool active, bool isAdmin)
        {
            Username = username;
            Password = password;
            Active = active;
            IsAdmin = isAdmin;
        }

        public string Username { get; set; }

        public string Password
        {
            get => _password;
            set => _password = PasswordHasher.HashString(value);
        }

        public bool Active { get; set; }
        public bool IsAdmin { get; set; }
        public int Id { get; set; }

        public bool Deleted { get; set; }
    }
}