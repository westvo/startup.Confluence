using StartUp.Confluence.Model;
using StartUp.Confluence.Model.Entities.Accounts;
using StartUp.Confluence.UnitOfWork.Repositories;
using StartUp.Confluence.UnitOfWork.Shared;

namespace StartUp.Confluence.Repository.Repository.Accounts
{
  public class IndustryRepository : Repository<Industry>, IRepository<Industry>
  {
    public IndustryRepository(ConfluenceDBContext dbContext) : base(dbContext)
    {

    }
  }
}
