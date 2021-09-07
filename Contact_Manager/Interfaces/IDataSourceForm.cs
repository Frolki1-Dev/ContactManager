namespace Contact_Manager.Interfaces
{
    /**
     * Helps to define the important functions for the data grid view forms
     */
    interface IDataSourceForm
    {
        /**
         * Update the data grid view
         */
        void UpdateSource();

        /**
         * Get the selected row from the data grid view
         */
        int GetSelectedRow();
    }
}