using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager.Models
{
    class Model
    {
        public bool insert()
        {
            try
            {
                DatabaseConnection.openDatabaseConnection();
                DatabaseConnection.startTransaction();

                DatabaseConnection.commit();
            } catch
            {
                DatabaseConnection.rollback();
            } finally
            {
                DatabaseConnection.closeDatabaseConnection();
            }
            return false;
        }

        public bool updateById(int rowId)
        {
            return false;
        }

        /**
         * Set the deleted flag
         */
        public bool delete(int rowId)
        {
            return false;
        }
    }
}
