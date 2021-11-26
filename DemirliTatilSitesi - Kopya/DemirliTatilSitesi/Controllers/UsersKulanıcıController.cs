using Core.DTOs;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemirliTatilSitesi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersKulanıcıController : CustomBaseController
    {
        private readonly IServiceGeneric<UsersKulanıcı, UsersKulanıcıDto> _UsersKulanıcı;

        public UsersKulanıcıController(IServiceGeneric<UsersKulanıcı, UsersKulanıcıDto> userKulanıcı1)
        {
            _UsersKulanıcı = userKulanıcı1;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return ActionResultInstance(await _UsersKulanıcı.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SaveProduct(UsersKulanıcıDto  usersKulanıcıDto )
        {
            return ActionResultInstance(await _UsersKulanıcı.AddAsync(usersKulanıcıDto));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductDto productDto)
        {
            return ActionResultInstance(await _UsersKulanıcı.Update(productDto, productDto.Id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return ActionResultInstance(await _UsersKulanıcı.Remove(id));
        }
    }
}

