namespace BasicContactList
{
    public interface IContactManager
    {
        void AddContact(string name, string phoneNumber, string? email, ContactType contactType);
        Contact? FindContact(string phoneNumber);
        void UpdateContact(string phoneNumber, string name, string email);
        void GetAllContacts();
        void GetContact(string phoneNumber);
        void DeleteContact(string phoneNumber);
    }
}
