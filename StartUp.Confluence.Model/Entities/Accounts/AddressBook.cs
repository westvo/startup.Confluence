using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Accounts
{
    public class AddressBook : BaseEntity
    {
        public string Position { get; set; }
        public string Description { get; set; }
        public System.Guid AccountId { get; set; }
        public System.Guid ContactId { get; set; }
        public Nullable<System.Guid> ParentContactId { get; set; }
        public string Department { get; set; }

        public virtual Account Account { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
