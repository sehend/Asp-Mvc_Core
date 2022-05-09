using Core;
using Core.IServices;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _repository.GetAll();
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


        public TEntity Find(object id)
        {
            return _repository.Get(id);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);

            _unitOfWork.Commit();
        }

    
    

        public TEntity GetByIdAsync(int id)
        {
            var musteri= _repository.GetByIdAsync(id);

            _unitOfWork.Commit();

            return musteri;
        }

        TEntity IService<TEntity>.Update(TEntity entity)
        {
          
                TEntity UpdateEntity = _repository.Update(entity);

                _unitOfWork.Commit();

                return UpdateEntity;


            
        }

    }
}
