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
    class Customers : Collection
    {
        public new Customer this[int i]
        {
            get => (Customer)List[i];

            set => List.Add(value);
        }

        protected override string GetDataContainerListName()
        {
            return DataContainer.Customers;
        }
    }
}
