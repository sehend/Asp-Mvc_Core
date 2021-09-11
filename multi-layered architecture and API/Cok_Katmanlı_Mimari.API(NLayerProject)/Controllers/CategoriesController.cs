using AutoMapper;
using Cok_Katmanlı_Mimari.API_NLayerProject_.DTOs;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cok_Katmanlı_Mimari.API_NLayerProject_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryService _categoryService;

        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;

            _mapper = mapper;

        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();



            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(categories));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var categoryler = await _categoryService.GetByIdAsync(id);


            return Ok(_mapper.Map<CategoryDto>(categoryler));

        }

        [HttpPost]

        public async Task<IActionResult> Save(CategoryDto categoryDto)
        {

          var newcategory =  await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));

            return Created(string.Empty,_mapper.Map<CategoryDto>(newcategory));

        }

        [HttpPut]
        public IActionResult Update(CategoryDto categoryDto)
        {

            var category =  _categoryService.Update(_mapper.Map<Category>(categoryDto));

            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            //Async kulan madan Async methot çagırma

            var category = _categoryService.GetByIdAsync(id).Result;

            _categoryService.Remove(category);

            return NoContent();

        }

        [HttpGet("{id}/products")]
        public async Task <IActionResult> GetWithProductsById(int id)
        {
            //Async kulan madan Async methot çagırma

            var category = await _categoryService.GetWithGetByIdAsync(id);

           

            return Ok(_mapper.Map<GetWithProductDto>(category));

        }

    }
}
