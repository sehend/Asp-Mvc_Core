using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebJwtProje.Controllers
{
    public class BlogController : Controller
    {

        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {

            var value = bm.GetBlockListWithGetCategory();


            return View(value);
        }

        public IActionResult BlogReadAll(int id)
        {

            ViewBag.i = id;

            var values = bm.GetBlogById(id);


            return View(values);
        }

 
    }
}
