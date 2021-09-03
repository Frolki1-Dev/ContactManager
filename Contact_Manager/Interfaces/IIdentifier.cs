namespace Contact_Manager.Interfaces
{
    /**
     * Set the default fields for all resources
     */
    public interface IIdentifier
    {
        int Id { get; set; }
        bool Deleted { get; set; }
    }
}