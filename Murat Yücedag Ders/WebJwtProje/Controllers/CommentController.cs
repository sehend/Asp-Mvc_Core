using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebJwtProje.Controllers
{
    public class CommentController : Controller
    {



        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAndComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlock(int id)
        {

            var values = cm.GetList(id);
            


            return PartialView(values);
        }
    }
}
