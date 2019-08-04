using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Accounts  
{
    public class Contact : BaseEntity
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public Nullable<int> Gender { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCountry { get; set; }
        public string Description { get; set; }
        public string Emails { get; set; }
        public string Phones { get; set; }
        public Nullable<System.Guid> AvatarMediaItemId { get; set; }
        public string SocialLinks { get; set; }

        public virtual ICollection<AddressBook> AddressBooks { get; set; }
        public virtual ICollection<ContactAudit> ContactAudits { get; set; }        
    }
}
