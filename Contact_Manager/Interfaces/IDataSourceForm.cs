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