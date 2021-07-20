namespace Contact_Manager.Interfaces
{
    public interface IIdentifier
    {
        int Id { get; set; }
        bool Deleted { get; set; }
    }
}
