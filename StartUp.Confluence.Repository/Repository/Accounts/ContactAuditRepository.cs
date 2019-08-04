using StartUp.Confluence.Model;
using StartUp.Confluence.Model.Entities.Accounts;
using StartUp.Confluence.UnitOfWork.Repositories;
using StartUp.Confluence.UnitOfWork.Shared;

namespace StartUp.Confluence.Repository.Repository.Accounts
{
  public class ContactAuditRepository : Repository<ContactAudit>, IRepository<ContactAudit>
  {
    public ContactAuditRepository(ConfluenceDBContext dbContext) : base(dbContext)
    {

    }
  }
}
