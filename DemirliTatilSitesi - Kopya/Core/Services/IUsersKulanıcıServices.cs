using Core.DTOs;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
   public interface IUsersKulanıcıServices
    {
        Task<Response<UsersKulanıcıDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<Response<UsersKulanıcıDto>> GetUserByNameAsync(string userName);
    }
}
