using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebJwtProje.Controllers
{
    public class RegisterController : Controller
    {

        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Index(Writer writer)
        {

            writerManager.WriterAdd(writer);



            return View();
        }
    }
}
