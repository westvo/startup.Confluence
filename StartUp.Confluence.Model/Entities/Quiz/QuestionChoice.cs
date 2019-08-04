using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Confluence
{
    public class QuestionChoice : BaseEntity
    {
        public Guid QuestionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Checked { get; set; }

        public virtual Question Question { get; set; }
    }
}
