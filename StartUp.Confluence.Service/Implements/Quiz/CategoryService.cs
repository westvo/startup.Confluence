using Microsoft.EntityFrameworkCore;
using StartUp.Helper;
using StartUp.Confluence.Model.Entities.Confluence;
using StartUp.Confluence.Service.Collections;
using StartUp.Confluence.Service.Shared.Confluence;
using StartUp.Confluence.UnitOfWork.Collections;
using StartUp.Confluence.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Confluence.Service.Implements.Confluence
{
  public class CategoryService : ServiceBase<Category>, IServiceBase<Category>, ICategoryService
  {
    IUnitOfWork _unitOfWork;
    public CategoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    public async Task<object> GetQuestions(Guid id)
    {
      var category = await _unitOfWork.GetRepository<Category>().GetFirstOrDefaultAsync(predicate: p => p.Id == id, include: c => c.Include(s => s.Questions));
      return Ultilities.ConvertModelToString(category);
    }
  }
}
