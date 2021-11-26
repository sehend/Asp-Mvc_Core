using Core.DTOs;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Identity;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class UsersKulanıcıServices : IUsersKulanıcıServices
    {
        private readonly UserManager<UsersKulanıcı> _userManager;

        public UsersKulanıcıServices(UserManager<UsersKulanıcı> userManager)
        {
            _userManager = userManager;
        }
        
        public async Task<Response<UsersKulanıcıDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new UsersKulanıcı { Email = createUserDto.Email, UserName = createUserDto.UserName };

            var result = await _userManager.CreateAsync(user, createUserDto.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();

                return Response<UsersKulanıcıDto>.Fail(new ErrorDto(errors, true), 400);
            }
            return Response<UsersKulanıcıDto>.Success(ObjectMapper.Mapper.Map<UsersKulanıcıDto>(user), 200);
        }
        public async Task<Response<UsersKulanıcıDto>> GetUserByNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return Response<UsersKulanıcıDto>.Fail("UserName not found", 404, true);
            }

            return Response<UsersKulanıcıDto>.Success(ObjectMapper.Mapper.Map<UsersKulanıcıDto>(user), 200);
        }
    }
}
