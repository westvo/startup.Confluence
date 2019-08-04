using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Confluence
{
    public enum QuestionType
    {
        CheckBox,
        Radio
    }
    public class Question : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string type { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<QuestionChoice> QuestionChoices { get; set; }

    }
}
