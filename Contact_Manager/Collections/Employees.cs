using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager.Models;

namespace Contact_Manager.Collections
{
    [Serializable]
    class Employees : CollectionBase
    {
        public void Add(Employee user)
        {
            List.Add(user);
        }

        public Employee this[int i]
        {
            get => (Employee)List[i];

            set => List.Add(value);
        }
    }
}
