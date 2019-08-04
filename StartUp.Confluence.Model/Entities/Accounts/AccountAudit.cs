using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Accounts
{
    public class AccountAudit : BaseEntity
    {
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public string BeforeValueString { get; set; }
        public string AfterValueString { get; set; }
        public Guid AccountId { get; set; }

        public virtual Account Account { get; set; }

    }
}
