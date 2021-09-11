using AutoMapper;
using Cok_Katmanlı_Mimari.API_NLayerProject_.DTOs;
using Cok_Katmanlı_Mimari.API_NLayerProject_.Filters;
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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;

            _mapper = mapper;

        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            throw new Exception("Tüm Dataları Çekerken Hata Meydana Geldi....");

            var products = await _productService.GetAllAsync();



            return Ok(_mapper.Map<IEnumerable<ProductDto>>(products));

        }
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var products = await _productService.GetByIdAsync(id);


            return Ok(_mapper.Map<ProductDto>(products));

        }

       

        [HttpPost]

        public async Task<IActionResult> Save(ProductDto productDto)
        {


            var newProduct = await _productService.AddAsync(_mapper.Map<Product>(productDto));

            return Created(string.Empty, _mapper.Map<CategoryDto>(newProduct));

        }

        [HttpPut]
        public IActionResult Update(ProductDto productDto)
        {

            var category = _productService.Update(_mapper.Map<Product>(productDto));

            return NoContent();

        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]

        public IActionResult Remove(int id)
        {
            //Async kulan madan Async methot çagırma

            var products = _productService.GetByIdAsync(id).Result;

            _productService.Remove(products);

            return NoContent();

        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}/category")]

        public async Task<IActionResult> GetWithCategoryById(int id)
        {
            //Async kulan madan Async methot çagırma

            var product = await _productService.GetWithCategoryByIdAsync(id);



            return Ok(_mapper.Map<ProductWithCategoryDto>(product));

        }
    }
}
