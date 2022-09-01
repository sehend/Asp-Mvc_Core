﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebJwtProje.ViewComponents.Category
{
    public class CategoryList :ViewComponent
    {


        CategoryManager cm = new CategoryManager(new EfCategoryRepository());


        public IViewComponentResult Invoke()
        {

            



            return View(cm.GetList());
        }


    }
}
