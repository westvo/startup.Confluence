using Microsoft.Extensions.Logging;
using StartUp.Confluence.UnitOfWork.Collections;
using StartUp.Confluence.UnitOfWork.Shared;
using StartUp.Confluence.Service.Shared.Confluence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StartUp.Confluence.Service.Collections;
using StartUp.Confluence.Model.Entities.Confluence;
using StartUp.Helper;
using Microsoft.EntityFrameworkCore;

namespace StartUp.Confluence.Service.Implements.Confluence
{
    public class QuestionService : ServiceBase<Question>, IServiceBase<Question>, IQuestionService
    {
        IUnitOfWork _unitOfWork;
        public QuestionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
                  
        public object CreateWithQuestionChoices(Question question)
        {
            var q = Create(question);
            var questionChoices = question.QuestionChoices;

            //TODO:: Create QuestionChoiceService file, with function Create(Guid QuestionId, ICollection<QuestionChoice> questionChoices)
            foreach (QuestionChoice qc in questionChoices)
            {
                qc.Id = new Guid();
                qc.QuestionId = q.Id;
            }
            _unitOfWork.GetRepository<QuestionChoice>().Insert(questionChoices);
            _unitOfWork.SaveChanges();
            var qResult = _unitOfWork.GetRepository<Question>().GetFirstOrDefault(predicate: p => p.Id==q.Id, include: a => a.Include(c => c.QuestionChoices));
            return Ultilities.ConvertModelToObject(qResult);
        }
}
}
