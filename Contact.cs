
namespace BasicContactList;

public class Contact : BaseClass
{
    public string Name { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string? Email { get; set; }
    public ContactType ContactType { get; set; }
}
