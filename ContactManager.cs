using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicContactList
{
    internal class ContactManager : IContactManager
    {
        public static List<Contact> Contacts = new();
        public void AddContact(string name, string phoneNumber, string? email)
        {
            int id = Contacts.Count > 0 ? Contacts.Count + 1 : 1;

            var isContactExist = IsContactExist(phoneNumber);

            if (isContactExist)
            {
                Console.WriteLine("Contact already exist!");
                return;
            }

            var contact = new Contact
            {
                Id = id,
                Name = name,
                PhoneNumber = phoneNumber,
                Email = email,
                CreatedAt = DateTime.Now
            };

            Contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
        }

        private bool IsContactExist(string phoneNumber)
        {
            return Contacts.Any(c => c.PhoneNumber == phoneNumber);
        }

        public void DeleteContact(string phoneNumber)
        {
            var contact = FindContact(phoneNumber);

            if (contact is null)
            {
                Console.WriteLine("Unable to delete contact as it does not exist!");
                return;
            }

            Contacts.Remove(contact);
        }

        public Contact? FindContact(string phoneNumber)
        {
            return Contacts.Find(c => c.PhoneNumber == phoneNumber);
        }

        public void GetContact(string phoneNumber)
        {
            var contact = FindContact(phoneNumber);
            if(contact is null)
            {
                Console.WriteLine($"Contact with {phoneNumber} not found");
            }
            else
            {
                Print(contact);
            }            
        }

        public void GetAllContacts()
        {
            if(Contacts.Count == 0)
            {
                Console.WriteLine("There is no contact added yet.");
                return;
            }

            foreach(var contact in Contacts)
            {
                Print(contact, true);
            }
        }

        public void UpdateContact(string phoneNumber, string name, string email)
        {
            var contact = FindContact(phoneNumber);

            if (contact is null)
            {
                Console.WriteLine("Contact does not exist!");
                return;
            }

            contact.Name = name;
            contact.Email = email;
            Console.WriteLine("Contact updated successfully.");
        }

        private void Print(Contact contact, bool full=false)
        {
            if (full)
            {
                Console.WriteLine($"{contact.Id}\t{contact.Name}\t{contact.PhoneNumber}\t{contact.Email}\t{contact.CreatedAt}");
            }
            else
            {
                Console.WriteLine($"Name: {contact!.Name}\nPhone Number: {contact!.PhoneNumber}\nEmail: {contact!.Email}");
            }

        }
    }
}
