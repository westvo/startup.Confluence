using StartUp.Confluence.Model.Entities.Spaces;
using StartUp.Confluence.Service.Collections;
using StartUp.Confluence.Service.Shared.Spaces;
using StartUp.Confluence.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Service.Implements.Spaces
{

  public class DocumentService : ServiceBase<Document>, IServiceBase<Document>, IDocumentService
  {
    IUnitOfWork _unitOfWork;
    public DocumentService(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
  }
}
