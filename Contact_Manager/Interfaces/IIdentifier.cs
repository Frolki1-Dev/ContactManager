namespace Contact_Manager.Interfaces
{
    interface IIdentifier
    {
        int Id { get; set; }
        bool Deleted { get; set; }
    }
}
