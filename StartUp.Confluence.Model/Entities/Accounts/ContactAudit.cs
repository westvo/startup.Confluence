using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Accounts
{
    public class ContactAudit : BaseEntity
    {
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public string BeforeValueString { get; set; }
        public string AfterValueString { get; set; }
        public System.Guid ContactId { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
