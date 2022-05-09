using Core.IServices;
using Core.Model;
using Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtomobilFirması.Controllers
{
    public class AnketController : Controller
    {
        private readonly IService<Anket> service;

        private readonly AppDbContext _appdbcontext;


        public AnketController(IService<Anket> service, AppDbContext appDbContext)
        {
            _appdbcontext = appDbContext;

            this.service = service;
        }

        public IActionResult Index()
        {

            var MüsterisGetAll = service.GetAll();


            return View(MüsterisGetAll);
        }


        public IActionResult AnketsSave()
        {




            return View();
        }
        [HttpPost]
        public IActionResult AnketSave(Anket model)
        {

            service.Save(model);


            return RedirectToAction("Index");
        }

        public IActionResult AnketUpdate(int id)
        {
            var sehend = service.GetByIdAsync((id));



            return View(sehend);
        }


        [HttpPost]

        public IActionResult AnketUpdate(Anket model)
        {
            var musteri = service.Update(model);



            return RedirectToAction("Index");
        }








        public IActionResult AnketDelete(int id = 0)
        {
            //Async kulan madan Async methot çagırma

            var category = service.GetByIdAsync(id);

            service.Remove(category);

            return RedirectToAction("Index");




        }
    }
}
