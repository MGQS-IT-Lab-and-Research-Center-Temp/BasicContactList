using ConsoleTables;
using Humanizer;

namespace BasicContactList
{
    internal sealed class ContactManager : IContactManager
    {
        public static List<Contact> Contacts = new();
        public void AddContact(string name, string phoneNumber, string? email, ContactType contactType)
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
                ContactType = contactType,
                CreatedAt = DateTime.Now
            };

            Contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
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
            
            if (contact is null)
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
            int contactCount = Contacts.Count;

            Console.WriteLine("You have " + "contact".ToQuantity(contactCount));

            if (contactCount == 0)
            {
                Console.WriteLine("There is no contact added yet.");
                return;
            }

            var table = new ConsoleTable("Id", "Name", "Phone Number", "Email", "Contact Type", "Date Created");

            foreach (var contact in Contacts)
            {
                table.AddRow(contact.Id, contact.Name, contact.PhoneNumber, contact.Email, ((ContactType)contact.ContactType).Humanize(), contact.CreatedAt.Humanize());
            }

            table.Write(Format.Alternative);
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

        private void Print(Contact contact)
        {
            Console.WriteLine($"Name: {contact!.Name}\nPhone Number: {contact!.PhoneNumber}\nEmail: {contact!.Email}");
        }

        private bool IsContactExist(string phoneNumber)
        {
            return Contacts.Any(c => c.PhoneNumber == phoneNumber);
        }
    }
}
