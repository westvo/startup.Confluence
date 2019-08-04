using StartUp.Confluence.Model;
using StartUp.Confluence.Model.Entities.Accounts;
using StartUp.Confluence.UnitOfWork.Repositories;
using StartUp.Confluence.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Repository.Repository.Accounts
{
  public class AccountAuditRepository : Repository<AccountAudit>, IRepository<AccountAudit>
  {
    public AccountAuditRepository(ConfluenceDBContext dbContext) : base(dbContext)
    {

    }
  }
}
