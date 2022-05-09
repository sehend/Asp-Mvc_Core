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
    public class AracBilgileriController : Controller
    {
        private readonly IService<AracBilgileri> service;

        private readonly AppDbContext _appdbcontext;


        public AracBilgileriController(IService<AracBilgileri> service, AppDbContext appDbContext)
        {
            _appdbcontext = appDbContext;

            this.service = service;
        }

        public IActionResult Index()
        {

            var MüsterisGetAll = service.GetAll();


            return View(MüsterisGetAll);
        }


        public IActionResult AracBilgileriSave()
        {




            return View();
        }
        [HttpPost]
        public IActionResult AracBilgileriSave(AracBilgileri model)
        {

            service.Save(model);


            return RedirectToAction("Index");
        }

        public IActionResult AracBilgileriUpdate(int id)
        {
            var sehend = service.GetByIdAsync((id));



            return View(sehend);
        }


        [HttpPost]

        public IActionResult AracBilgileriUpdate(AracBilgileri model)
        {
            var musteri = service.Update(model);



            return RedirectToAction("Index");
        }








        public IActionResult AracBilgileriDelete(int id = 0)
        {
            //Async kulan madan Async methot çagırma

            var category = service.GetByIdAsync(id);

            service.Remove(category);

            return RedirectToAction("Index");




        }
    }
}
