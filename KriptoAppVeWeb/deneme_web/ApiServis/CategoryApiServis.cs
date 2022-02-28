using deneme_web.Dto;
using KriptoAppVeWeb.Models;
using KriptoCore.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace deneme_web.ApiServis
{
    public class CategoryApiServis
    {

        private readonly HttpClient _httpClient;

        public CategoryApiServis(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }

        public async Task<IEnumerable<sehend>> GetAllAsync()
        {

            IEnumerable<sehend> categoryDtos;

            var response = await _httpClient.GetAsync("KriptoApi");

            if (response.IsSuccessStatusCode)
            {
                categoryDtos = JsonConvert.DeserializeObject<IEnumerable<sehend>>(await response.Content.ReadAsStringAsync());


            }

            else

            {
                categoryDtos = null;
            }


            return categoryDtos;


        }

    }
}
