using StartUp.Confluence.Model;                    
using StartUp.Confluence.Model.Entities.Confluence;
using StartUp.Confluence.UnitOfWork.Repositories;
using StartUp.Confluence.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Repository.Repository.Confluence
{
  public class QuestionRepository : Repository<Question>, IRepository<Question>
  {
    public QuestionRepository(ConfluenceDBContext dbContext) : base(dbContext)
    {

    }
  }
}
