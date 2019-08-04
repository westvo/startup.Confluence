using Microsoft.Extensions.DependencyInjection;
using StartUp.Confluence.Service.Implements.Confluence;
using StartUp.Confluence.Model.Entities.Confluence;
using StartUp.Confluence.Service.Collections;               
using StartUp.Confluence.Service.Shared;
using StartUp.Confluence.Service.Shared.Confluence;
using StartUp.Confluence.Service.Implements.Spaces;
using StartUp.Confluence.Model.Entities.Spaces;
using StartUp.Confluence.Service.Shared.Spaces;

namespace StartUp.Confluence.Service.Extension
{
  public static class ServicesCollection
  {
    public static IServiceCollection AddServicesInstance(this IServiceCollection services)
    {
      services.AddScoped<IServiceBase<Space>, SpaceService>();
      services.AddScoped<ISpaceService, SpaceService>();
                             
      services.AddScoped<IServiceBase<Content>, ContentService>();
      services.AddScoped<IContentService, ContentService>();
                         
      services.AddScoped<IServiceBase<Question>, QuestionService>();
      services.AddScoped<IQuestionService, QuestionService>();

      services.AddScoped<IServiceBase<Category>, CategoryService>();
      services.AddScoped<ICategoryService, CategoryService>();
 
      services.AddScoped<IServiceBase<QuestionChoice>, QuestionChoiceService>();
      services.AddScoped<IQuestionChoiceService, QuestionChoiceService>();
      return services;
    }

    //public static IServiceCollection AddServicesInstance<TEntity, TService>(this IServiceCollection services) where TEntity : class  where TService : class, IServiceBase<TEntity>
    //{
    //    services.AddScoped<IServiceBase<TEntity>, TService>();
    //    return services;
    //}
  }
}
