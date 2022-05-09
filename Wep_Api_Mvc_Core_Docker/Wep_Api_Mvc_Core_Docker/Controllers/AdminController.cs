using AutoMapper;

using Core.Model;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wep_Api_Mvc_Core_Docker.DTOs;

namespace Wep_Api_Mvc_Core_Docker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IService<Admin> _personServices;

        private readonly IMapper _mapper;


        public AdminController(IService<Admin> service, IMapper mapper)
        {
            _personServices = service;

            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
        

            var products = await _personServices.GetAllAsync();



            return Ok(_mapper.Map<IEnumerable<AdminDto>>(products));

        }
      
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var products = await _personServices.GetByIdAsync(id);


            return Ok(_mapper.Map<AdminDto>(products));

        }



        [HttpPost]


        public async Task<IActionResult> Save(AdminDto productDto)
        {


            var newProduct = await _personServices.AddAsync(_mapper.Map<Admin>(productDto));

            return Created(string.Empty, _mapper.Map<AdminDto>(newProduct));

        }

        [HttpPut]
        public IActionResult Update(AdminDto productDto)
        {

            var category = _personServices.Update(_mapper.Map<Admin>(productDto));

            return NoContent();

        }

     
        [HttpDelete("{id}")]

        public IActionResult Remove(int id)
        {
            //Async kulan madan Async methot çagırma

            var products = _personServices.GetByIdAsync(id).Result;

            _personServices.Remove(products);

            return NoContent();

        }

     
      

    }
}
