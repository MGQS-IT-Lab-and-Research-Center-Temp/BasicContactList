using System.ComponentModel;

namespace BasicContactList
{
    public enum ContactType
    {
        [Description("Family and Friends")]
        FamilyAndFriends = 1,

        [Description("Work or Business")]
        WorkOrBusiness
    }
}