using StartUp.Confluence.Model.Entities;
using StartUp.Confluence.UnitOfWork.Collections;
using StartUp.Confluence.UnitOfWork.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StartUp.Confluence.Service.Collections
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class, IEntity
    {
        IUnitOfWork _unitOfWork;

        public ServiceBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public TEntity Create(TEntity entity)
        {
            entity.Id = new Guid();
            _unitOfWork.GetRepository<TEntity>().Insert(entity);
            _unitOfWork.SaveChanges();
            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            _unitOfWork.GetRepository<TEntity>().Delete(entity);
            _unitOfWork.SaveChanges();
            return entity;
        }

        public TEntity Get(Guid id)
        {
           var e =  _unitOfWork.GetRepository<TEntity>().GetFirstOrDefault(predicate: b => b.Id == id);
            return e;
        }

        public TEntity Delete(Guid id)
        {
            var e = _unitOfWork.GetRepository<TEntity>().GetFirstOrDefault(predicate: b => b.Id == id);
            if(e!=null)
            _unitOfWork.GetRepository<TEntity>().Delete(id);
            _unitOfWork.SaveChanges();
            return e;

        }

        public virtual async Task<IPagedList<TEntity>> GetAllAsync()
        {
            return await _unitOfWork.GetRepository<TEntity>().GetPagedListAsync();
        }

        public TEntity Update(TEntity entity)
        {
            _unitOfWork.GetRepository<TEntity>().Update(entity);
            _unitOfWork.SaveChanges();
            return entity;
        }
    }
}
