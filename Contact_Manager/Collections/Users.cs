using System;
using System.Collections.Generic;
using System.Linq;
using Contact_Manager.Models;

namespace Contact_Manager.Collections
{
    /**
     * Stores all users
     */
    [Serializable]
    class Users : Collection
    {
        public new User this[int i]
        {
            get => (User) List[i];

            set => List.Add(value);
        }

        /**
         * Checks if the username exists already
         */
        public bool UsernameExists(string username)
        {
            // Convert the IList to a normal list
            List<User> list = List.Cast<User>().ToList();
            // Search for the username
            int index = list.FindIndex(user => user.Username.ToLower().Trim() == username.ToLower().Trim());

            return index > -1;
        }

        protected override string GetDataContainerListName()
        {
            return DataContainer.Users;
        }
    }
}