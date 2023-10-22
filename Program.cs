using BasicContactList;

Contact contact = new();

contact.UpdateContact("08025207486", "Hasbiyallah", "hasbi@googlemail.com");
contact.DeleteContact("08123456789");
contact.ViewContacts();
contact.ViewContact("08123456789");