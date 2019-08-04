using StartUp.Confluence.Model.Entities.Spaces;
using StartUp.Confluence.Service.Collections;
using StartUp.Confluence.Service.Shared.Spaces;
using StartUp.Confluence.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Service.Implements.Spaces
{
  public class SpaceService : ServiceBase<Space>, IServiceBase<Space>, ISpaceService
  {
    IUnitOfWork _unitOfWork;
    public SpaceService(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
  }
}
