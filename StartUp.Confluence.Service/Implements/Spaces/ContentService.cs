using StartUp.Confluence.Model.Entities.Spaces;
using StartUp.Confluence.Service.Collections;
using StartUp.Confluence.Service.Shared.Spaces;
using StartUp.Confluence.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Service.Implements.Spaces
{

  public class ContentService : ServiceBase<Content>, IServiceBase<Content>, IContentService
  {
    IUnitOfWork _unitOfWork;
    public ContentService(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
  }
}
