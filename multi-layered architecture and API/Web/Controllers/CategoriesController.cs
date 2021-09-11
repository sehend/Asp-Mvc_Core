using AutoMapper;
using Core.Models;using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.ApiServis;
using Web.DTOs;

namespace Web.Controllers
{
    public class CategoriesController : Controller
    {


       

        private readonly IMapper _mapper;

        private readonly CategoryApiServis _categoryApiServis;


        public CategoriesController( IMapper mapper , CategoryApiServis categoryApiServis )
        {
            

            _mapper = mapper;

            _categoryApiServis = categoryApiServis;

        }

   
        public async Task<IActionResult> Index()
        {
            var categpries = await _categoryApiServis.GetAllAsync();


            return View(_mapper.Map<IEnumerable<CategoryDto>>(categpries));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {

            await _categoryApiServis.AddAsync(categoryDto);

            return RedirectToAction("Index");

        }






    
        public async Task<IActionResult> Edit(int id)
        {

          var categries =  await _categoryApiServis.GetByIdAsync((id));

            return View(_mapper.Map<CategoryDto>(categries));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CategoryDto categoryDto)
        {

             await _categoryApiServis.Update(categoryDto);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {

           

           await  _categoryApiServis.Remove(id);

            return RedirectToAction("Index");
        }
    }
}
