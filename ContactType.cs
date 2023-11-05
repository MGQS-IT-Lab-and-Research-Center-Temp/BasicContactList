using System.ComponentModel;

namespace BasicContactList
{
    public enum ContactType
    {
        [Description("Family and Friends")]
        FamilyAndFriends,

        [Description("Work or Business")]
        WorkOrBusiness
    }
}