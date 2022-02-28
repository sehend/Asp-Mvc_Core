using AutoMapper;
using deneme_web.ApiServis;
using deneme_web.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deneme_web.Controllers
{
    public class kriptosehendController : Controller
    {
        private readonly IMapper _mapper;

        private readonly CategoryApiServis _categoryApiServis;


        public kriptosehendController(IMapper mapper, CategoryApiServis categoryApiServis)
        {


            _mapper = mapper;

            _categoryApiServis = categoryApiServis;

        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Privacy()
        {
            var categpries = await _categoryApiServis.GetAllAsync();


            return View(_mapper.Map<IEnumerable<CategoryDto>>(categpries));
        }

        

    }
}
