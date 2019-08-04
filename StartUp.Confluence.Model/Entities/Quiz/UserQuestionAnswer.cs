using StartUp.Confluence.Model.Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Confluence
{
    public class UserQuestionAnswer : BaseEntity
    {
        public Guid AccountId { get; set; }
        public Guid QuestionChoiceId { get; set; }
        public bool Checked { get; set; }

        public virtual QuestionChoice QuestionChoice { get; set; }
        public virtual Account Account { get; set; }
    }
}
