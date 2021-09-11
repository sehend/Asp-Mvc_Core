using Core.Repositories;
using Core.UnitOfWork;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private ProductRepository _productRepository;

        private CategoryRepository _categoryRepository;

        public IProductRepository Product => _productRepository = _productRepository ?? new ProductRepository(_context);
        public ICategoryRepository category => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }



        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
