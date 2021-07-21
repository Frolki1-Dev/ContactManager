using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Contact_Manager.Models;

namespace Contact_Manager.Collections
{
    [Serializable]
    class Users : Collection
    {
        /**
         * Checks if the username exists already
         */
        public bool UsernameExists(string username)
        {
            // Convert the IList to a normal list
            List<User> list = List.Cast<User>().ToList();
            // Search for the username
            int index = list.FindIndex(user => user.Username == username);

            return index > 0;
        }

        protected override string GetDataContainerListName()
        {
            return DataContainer.Users;
        }

        public new User this[int i]
        {
            get => (User) List[i];

            set => List.Add(value);
        }
    }
}
