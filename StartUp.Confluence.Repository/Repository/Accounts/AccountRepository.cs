using StartUp.Confluence.Model;
using StartUp.Confluence.Model.Entities.Accounts;
using StartUp.Confluence.UnitOfWork.Repositories;
using StartUp.Confluence.UnitOfWork.Shared;

namespace StartUp.Confluence.Repository.Repository.Accounts
{
  public class AccountRepository : Repository<Account>, IRepository<Account>
  {
    public AccountRepository(ConfluenceDBContext dbContext) : base(dbContext)
    {

    }
  }
}
