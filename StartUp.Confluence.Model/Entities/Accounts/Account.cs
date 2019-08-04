using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Accounts
{
    public class Account : BaseEntity
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCountry { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public Guid AccountTypeId { get; set; }
        public Guid IndustryId { get; set; }
        public string Emails { get; set; }
        public string Phones { get; set; }
        public Guid? AvatarMediaItemId { get; set; }
        public string SocialLinks { get; set; }

        public virtual ICollection<AccountAudit> AccountAudits { get; set; }
        public virtual AccountType AccountType { get; set; }
        public virtual Industry Industry { get; set; }                               
    }
}
