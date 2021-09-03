using System;
using Contact_Manager.Models;

namespace Contact_Manager.Collections
{
    /**
     * Stores all customers
     */
    [Serializable]
    class Customers : Collection
    {
        public new Customer this[int i]
        {
            get => (Customer) List[i];

            set => List.Add(value);
        }

        protected override string GetDataContainerListName()
        {
            return DataContainer.Customers;
        }
    }
}