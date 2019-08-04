using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Model.Entities.Confluence
{
    public enum CategoryType
    {
        Level,   //Luyện Thi N5, N4, N3, N2
        Skill,   //KanjiTest, //PracticeGrammar, //FillInTheWord, //SelectTheCorrectAnswers, //GrammarSynthesis,
        Exam,    //Đề Số 1, Đề số 2...

    }

    public class Category : BaseEntity
    {                                   
        public string Name { get; set; }           //or Title
        public string Description { get; set; }    //or Content
        public string type { get; set; }
        public Guid? ParentId { get; set; }

        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Children { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        
    }
}
