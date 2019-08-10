using Microsoft.Extensions.DependencyInjection;
using StartUp.Confluence.Model.Entities.Accounts;
using StartUp.Confluence.Model.Entities.Confluence;
using StartUp.Confluence.Model.Entities.Spaces;
using StartUp.Confluence.Repository.Repository.Accounts;
using StartUp.Confluence.Repository.Repository.Confluence;
using StartUp.Confluence.Repository.Repository.Spaces;
using StartUp.Confluence.UnitOfWork.Shared;

namespace StartUp.Confluence.Repository.Extension
{
  public static class RepositoryCollection
  {
    public static IServiceCollection AddRepositoriesInstance(this IServiceCollection service)
    {
      //service.AddScoped<IUnitOfWork, UnitOfWork>();

      service.AddCustomRepository<AccountAudit, AccountAuditRepository>();
      service.AddCustomRepository<Account, AccountRepository>();
      service.AddCustomRepository<AccountType, AccountTypeRepository>();
      service.AddCustomRepository<AddressBook, AddressBookRepository>();
      service.AddCustomRepository<ContactAudit, ContactAuditRepository>();
      service.AddCustomRepository<Contact, ContactRepository>();
      service.AddCustomRepository<Industry, IndustryRepository>();

      service.AddCustomRepository<Space, SpaceRepository>();
      service.AddCustomRepository<Document, DocumentRepository>();
      service.AddCustomRepository<Category, CategoryRepository>();
      service.AddCustomRepository<Question, QuestionRepository>();
      service.AddCustomRepository<QuestionChoice, QuestionChoiceRepository>();
      service.AddCustomRepository<UserQuestionAnswer, UserQuestionAnswerRepository>();


      return service;
    }
  }
}
