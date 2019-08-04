using StartUp.Confluence.Model.Entities.Confluence;
using StartUp.Confluence.Service.Collections;
using StartUp.Confluence.Service.Shared.Confluence;
using StartUp.Confluence.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace StartUp.Confluence.Service.Implements.Confluence
{
    public class QuestionChoiceService : ServiceBase<QuestionChoice>, IServiceBase<QuestionChoice>, IQuestionChoiceService
    {
        IUnitOfWork _unitOfWork;
        public QuestionChoiceService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
