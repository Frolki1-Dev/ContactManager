using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using Contact_Manager.Models;

namespace Contact_Manager.Collections
{
    [Serializable]
    class Users : CollectionBase
    {
        public void Add(User user)
        {
            // Set the id
            user.Id = GetNextId();

            // Add the user
            List.Add(user);

            Save();
        }

        private int GetNextId()
        {
            // Check if we have data in the list
            if (List.Count < 1)
            {
                // The start index
                return 1;
            }

            // Convert the IList to a normal list
            List<User> list = List.Cast<User>().ToList();
            // Get the max id from the list
            int max = list.Max(u => u.Id);
            // Add one to the max id
            return max + 1;
        }

        private int GetIndexFromId(int id)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (this[i].Id == id)
                {
                    return i;
                }
            }

            return 0;
        }

        public void Edit(User user)
        {
            // Find the index
            int index = GetIndexFromId(user.Id);

            if (index == 0)
            {
                // We have a problem!
                throw new InvalidDataException("The user id " + user.Id + " was not founded in the list!");
            }

            // Remove the index and add the user new to the list
            List.RemoveAt(index);
            List.Add(user);
            Save();
        }

        public void Delete(int id)
        {
            foreach (User user in List)
            {
                // Check if the id are the same
                if (user.Id == id)
                {
                    user.Deleted = true;
                    break; // Stop the foreach loop
                }
            }

            Save();
        }

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

        private void Save()
        {
            DataContainer.SaveList(DataContainer.Users);
        }

        public User this[int i]
        {
            get => (User) List[i];

            set => List.Add(value);
        }
    }
}
