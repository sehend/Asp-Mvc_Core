using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetWithGetByIdAsync(int categoryId)
        {
            return await _appDbContext.categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}
