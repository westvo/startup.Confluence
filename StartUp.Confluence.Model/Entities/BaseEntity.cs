using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StartUp.Confluence.Model.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }

    public class BaseEntity : IEntity
    {
        [Key]
        public System.Guid Id { get; set; }

        public Guid? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastModified { get; set; }
        public Guid?  OwnerId { get; set; }
        public int? Flags { get; set; }
    }
}
