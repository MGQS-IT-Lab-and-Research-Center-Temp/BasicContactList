using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicContactList
{
    public interface IContactManager
    {
        void AddContact(string name, string phoneNumber, string? email);
        Contact? FindContact(string phoneNumber);
        void UpdateContact(string phoneNumber, string name, string email);
        void GetAllContacts();
        void GetContact(string phoneNumber);
        void DeleteContact(string phoneNumber);
    }
}
