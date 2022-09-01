using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IblogService
    {
        IBlogDal BlogDal;

        public BlogManager(IBlogDal blogDal)
        {
            BlogDal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogRemove(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlockListWithGetCategory()
        {
            return BlogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogById(int id)
        {
            return BlogDal.GetListAll(x => x.BlogID == id);
        }



        public List<Blog> GetList()
        {
            return BlogDal.GetListAll();
        }
    }
}
