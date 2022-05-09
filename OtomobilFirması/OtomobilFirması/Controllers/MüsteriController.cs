using Core.IServices;
using Core.Model;
using Data;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtomobilFirması.Controllers
{
    public class MüsteriController : Controller
    {
        private readonly IService<MüsteriBilgileri> service;

        private readonly AppDbContext _appdbcontext;


        public MüsteriController(IService<MüsteriBilgileri> service, AppDbContext appDbContext)
        {
            _appdbcontext = appDbContext;

            this.service = service;
        }

        public IActionResult Index()
        {

            var MüsterisGetAll = service.GetAll();


            return View(MüsterisGetAll);
        }


        public IActionResult MüsterisSave()
        {

           


            return View();
        }
        [HttpPost]
        public IActionResult MüsterisSave(MüsteriBilgileri model)
        {

            service.Save(model);


            return RedirectToAction("Index");
        }

        public IActionResult MüsterisUpdate(int id)
        {
            var sehend = service.GetByIdAsync((id));



              return View(sehend);
        }


        [HttpPost]

        public IActionResult MüsterisUpdate(MüsteriBilgileri model)
        {
            var musteri = service.Update(model);



            return RedirectToAction("Index");
        }

      






        public IActionResult MüsterisDelete(int id = 0)
        {
            //Async kulan madan Async methot çagırma

            var category = service.GetByIdAsync(id);

            service.Remove(category);

            return RedirectToAction("Index");




        }
    }
}
