
namespace BasicContactList;

public class Contact : BaseClass
{
    List<Contact> contactList = new();
    public string Name { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string? Email { get; set; }

}
