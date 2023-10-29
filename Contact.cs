
namespace BasicContactList;

public class Contact : BaseClass
{
    List<Contact> contactList = new();
    public string Name { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string? Email { get; set; }

    public Contact(int id, string name, string phoneNumber, string? email, DateTime createdAt)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
        CreatedAt = createdAt;
    }

    public Contact()
    {
        contactList = new List<Contact>{
            new(1,"Bolu", "081992883899", "bolu@gmail.com", new DateTime(2022, 10, 11)),
            new(2, "Basit", "08123456789", "basit@gmail.com", new DateTime(2022, 01, 12)),
            new(3, "Olaide", "08025207486", "ola@gmail.com", DateTime.Now)
        };
    }

    public void AddContact(string name, string phoneNumber, string? email)
    {
        int id = contactList.Count > 0 ? contactList.Count + 1 : 1;

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

        contactList.Add(contact);
    }

    public bool IsContactExist(string phoneNumber)
    {
        return contactList.Any(c => c.PhoneNumber == phoneNumber);
    }

    public Contact? FindContact(string phoneNumber)
    {
        return contactList.Find(c => c.PhoneNumber == phoneNumber);
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
    }

    public void ViewContact(string phoneNumber)
    {
        var contact = FindContact(phoneNumber);

        if (contact == null)
        {
            Console.WriteLine("Contact does not exist!");
            return;
        }

        Console.WriteLine($"Name: {contact!.Name}\nPhone Number: {contact!.PhoneNumber}\nEmail: {contact!.Email}");
    }

    public void ViewContact()
    {
        foreach (var contact in contactList)
        {
            Console.WriteLine($"{contact.Id}\t{contact.Name}\t{contact.PhoneNumber}\t{contact.Email}\t{contact.CreatedAt}");
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
