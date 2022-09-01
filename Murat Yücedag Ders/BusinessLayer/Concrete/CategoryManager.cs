using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {


        ICategoryDal  categoryDal;

       

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            categoryDal.Insert(category);
        }

        public void CategoryRemove(Category category)
        {
            categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            categoryDal.Update(category); 
        }

        public Category GetById(int id)
        {
            return categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return categoryDal.GetListAll();
        }
    }
}
