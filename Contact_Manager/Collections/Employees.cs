using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager.Models;

namespace Contact_Manager.Collections
{
    /**
     * Stores all employees
     */
    [Serializable]
    class Employees : Collection
    {
        public new Employee this[int i]
        {
            get => (Employee)List[i];

            set => List.Add(value);
        }

        protected override string GetDataContainerListName()
        {
            return DataContainer.Employees;
        }
    }
}
