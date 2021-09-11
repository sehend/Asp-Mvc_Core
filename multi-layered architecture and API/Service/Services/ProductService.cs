using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
          return  await _unitOfWork.Product.GetWithCategoryByIdAsync(productId);
        }
    }
}
