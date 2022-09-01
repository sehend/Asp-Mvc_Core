using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebJwtProje.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoryRepository());


        public IActionResult Index()
        {

            var valuse = cm.GetList();


            return View(valuse);
        }
    }
}
