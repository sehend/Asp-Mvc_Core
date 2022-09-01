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
    public class CommentManager : ICommentService
    {
       

        ICommentDal commentDal { get; set; }

        public CommentManager(ICommentDal commentDal)
        {
            this.commentDal = commentDal;
        }



        public void CommentAdd(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
            return commentDal.GetListAll(x => x.BlogID == id);
        }
    }
}
