namespace BasicContactList;

public class Contact
{
    // Data stored in a List - Our Data Store
    List<Contact> contactList = new();
    public string name;
    public string phoneNumber;
    public string? email;

    public Contact()
    {
        contactList =  new List<Contact>{
            new("Bolu", "081992883899", "bolu@gmail.com"),
            new("Basit", "08123456789", "basit@gmail.com"),
            new("Olaide", "08025207486", "ola@gmail.com")
        };
    }

    public Contact(string name, string phoneNumber, string email)
    {
        this.name = name;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }

    public Contact? FindContact(string phoneNumber)
    {
        return contactList.Find(c => c.phoneNumber == phoneNumber);
    }

    public void ViewContact(string phoneNumber)
    {
        var contact = FindContact(phoneNumber);

        if (contact is null)
        {
            Console.WriteLine("Contact does not exist!");
            return;
        }

        Console.WriteLine($"Name: {contact!.name}\nPhone Number: {contact!.phoneNumber}\nEmail: {contact!.email}");
    }

    public void UpdateContact(string phoneNumber, string name, string email)
    {
        var contact = FindContact(phoneNumber);

        if (contact is null)
        {
            Console.WriteLine("Contact does not exist!");
            return;
        }

        contact.name = name;
        contact.email = email;
    }

    public void ViewContacts()
    {
        foreach (var contact in contactList)
        {
            Console.WriteLine($"{contact.name}\t{contact.phoneNumber}\t{contact.email}");
        }
    }

    public void DeleteContact(string phoneNumber)
    {
        var contact = FindContact(phoneNumber);

        if (contact is null)
        {
            Console.WriteLine("Unable to delete contact as it does not exist!");
            return;
        }

        contactList.Remove(contact);
    }
}
