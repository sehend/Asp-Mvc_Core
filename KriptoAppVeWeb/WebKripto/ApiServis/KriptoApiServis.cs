using KriptoAppVeWeb.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebKripto.DTOs;

namespace WebKripto.ApiServis
{
    public class KriptoApiServis
    {
        private readonly HttpClient _httpClient;

        public KriptoApiServis(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {

            IEnumerable<CategoryDto> categoryDtos;

            var response = await _httpClient.GetAsync("KriptoApi");

            if (response.IsSuccessStatusCode)
            {
                categoryDtos = JsonConvert.DeserializeObject<IEnumerable<CategoryDto>>(await response.Content.ReadAsStringAsync());


            }

            else

            {
                categoryDtos = null;
            }


            return categoryDtos;


        }
    }
}
