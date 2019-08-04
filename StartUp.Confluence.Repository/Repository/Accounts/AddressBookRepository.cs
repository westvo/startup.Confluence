using StartUp.Confluence.Model;
using StartUp.Confluence.Model.Entities.Accounts;
using StartUp.Confluence.UnitOfWork.Repositories;
using StartUp.Confluence.UnitOfWork.Shared;

namespace StartUp.Confluence.Repository.Repository.Accounts
{
  public class AddressBookRepository : Repository<AddressBook>, IRepository<AddressBook>
  {
    public AddressBookRepository(ConfluenceDBContext dbContext) : base(dbContext)
    {

    }
  }
}
