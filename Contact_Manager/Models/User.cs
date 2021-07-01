﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager.Authentication;

namespace Contact_Manager.Models
{
    [Serializable]
    class User
    {
        public string Username { get; set; }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = PasswordHasher.HashString(value);
            }
        }

        public bool Active { get; set; }
        public bool IsAdmin { get; set; }
        public User(string username, string password, bool active, bool isAdmin)
        {
            Username = username;
            Password = password;
            Active = active;
            IsAdmin = isAdmin;
        }
    }
}
