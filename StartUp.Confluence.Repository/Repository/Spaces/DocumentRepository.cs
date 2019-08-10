using StartUp.Confluence.Model;
using StartUp.Confluence.Model.Entities.Spaces;
using StartUp.Confluence.UnitOfWork.Repositories;
using StartUp.Confluence.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Repository.Repository.Spaces
{
  public class DocumentRepository : Repository<Document>, IRepository<Document>
  {
    public DocumentRepository(ConfluenceDBContext dbContext) : base(dbContext)
    {

    }
  }
}
