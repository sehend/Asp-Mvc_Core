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
    public class SiteSakiniController : ControllerBase
    {
        private readonly IService<SiteSakini> _personServices;

        private readonly IMapper _mapper;


        public SiteSakiniController(IService<SiteSakini> service, IMapper mapper)
        {
            _personServices = service;

            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {


            var products = await _personServices.GetAllAsync();



            return Ok(_mapper.Map<IEnumerable<SiteSakiniDto>>(products));

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var products = await _personServices.GetByIdAsync(id);


            return Ok(_mapper.Map<SiteSakiniDto>(products));

        }



        [HttpPost]


        public async Task<IActionResult> Save(SiteSakiniDto productDto)
        {


            var newProduct = await _personServices.AddAsync(_mapper.Map<SiteSakini>(productDto));

            return Created(string.Empty, _mapper.Map<SiteSakiniDto>(newProduct));

        }

        [HttpPut]
        public IActionResult Update(SatısDto productDto)
        {

            var category = _personServices.Update(_mapper.Map<SiteSakini>(productDto));

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
