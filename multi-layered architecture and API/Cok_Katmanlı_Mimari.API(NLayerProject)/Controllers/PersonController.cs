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
    public class PersonController : ControllerBase
    {
        private readonly IService<Person> _personServices;

        public PersonController(IService<Person> service)
        {
            _personServices = service;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            

            var persons = await _personServices.GetAllAsync();

            return Ok(persons);
        }

        [HttpPut]
        public async Task<IActionResult> Save(Person person)
        {
            var NewPersons = await _personServices.AddAsync(person);

            return Ok(NewPersons);
        }


    }
}
