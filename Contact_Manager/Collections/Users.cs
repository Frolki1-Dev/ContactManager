using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Contact_Manager.Models;

namespace Contact_Manager.Collections
{
    [Serializable]
    class Users : CollectionBase
    {
        public void Add(User user)
        {
            List.Add(user);
        }

        public User this[int i]
        {
            get => (User) List[i];

            set => List.Add(value);
        }
    }
}
