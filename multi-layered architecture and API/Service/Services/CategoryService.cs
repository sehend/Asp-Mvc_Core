
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
   public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithGetByIdAsync(int categoryId)
        {
            return await _unitOfWork.category.GetWithGetByIdAsync(categoryId);
        }
    }
}
