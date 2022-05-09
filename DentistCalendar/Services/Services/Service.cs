using Core;
using Core.IServices;
using Core.Model;
using Core.Models;
using Core.Repositories;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        public readonly IUnitOfWork _unitOfWork;

        protected readonly IRepository<TEntity> _repository;

        public Service(IUnitOfWork unitOfWork, IRepository<TEntity> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return  _repository.GetAll();
        }


        public void Save(TEntity entity)
        {
            _repository.Save(entity);
            _unitOfWork.Commit();
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);

            _unitOfWork.Commit();
        }

        public void Delete(object id)
        {
            _repository.Delete(id);
            _unitOfWork.Commit();

        }

        public TEntity Find(object id)
        {
            return _repository.Get(id);
        }

        //public TEntity GetByIdAsync(string userId )
        //{
        //    return _repository.GetByIdAsync(userId);
        //}



        //public async Task<TEntity> AddAsync(TEntity entity)
        //{
        //    await _repository.AddAsync(entity);

        //    await _unitOfWork.CommitAsync();

        //    return entity;

        //}

        //public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        //{
        //    await _repository.AddRangeAsync(entities);

        //    await _unitOfWork.CommitAsync();

        //    return entities;
        //}

        //public async Task<IEnumerable<TEntity>> GetAllAsync()
        //{
        //    return await _repository.GetAllAsync();
        //}

        //public async Task<TEntity> GetByIdAsync(int id)
        //{
        //    return await _repository.GetByIdAsync(id);
        //}

        //public void Remove(TEntity entity)
        //{
        //    _repository.Remove(entity);

        //    _unitOfWork.Commit();
        //}

        //public void RemoveRange(IEnumerable<TEntity> entities)
        //{
        //    _repository.RemoveRange(entities);

        //    _unitOfWork.Commit();
        //}

        //public async Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        //{
        //    return await _repository.SingleOrDefault(predicate);
        //}

        //public TEntity Update(TEntity entity)
        //{
        //    TEntity UpdateEntity = _repository.Update(entity);

        //    _unitOfWork.Commit();

        //    return UpdateEntity;


        //}

        //public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        //{
        //    return await _repository.Where(predicate);
        //}
    }
}
