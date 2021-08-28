using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager.Interfaces
{
    /**
     * Helps to define the important functions for the data grid view forms
     */
    interface IDataSourceForm
    {
        void UpdateSource();

        int GetSelectedRow();
    }
}
