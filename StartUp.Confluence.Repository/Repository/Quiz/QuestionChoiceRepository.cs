using StartUp.Confluence.Model;
using StartUp.Confluence.Model.Entities.Confluence;
using StartUp.Confluence.UnitOfWork.Repositories;
using StartUp.Confluence.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Repository.Repository.Confluence
{
    public class QuestionChoiceRepository : Repository<QuestionChoice>, IRepository<QuestionChoice>
    {
        public QuestionChoiceRepository(ConfluenceDBContext dbContext) : base(dbContext)
        {

        }
    }
}
