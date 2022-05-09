using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using Web.Models;

namespace Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public AccountController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult SingIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SingIn(UserLoginModel model)
        {
            var client = _httpClientFactory.CreateClient();

            var requestContent = new StringContent(JsonSerializer.Serialize(model),Encoding.UTF8,"application/json");

            var response = await client.PostAsync("http://localhost:5097/api/Auth/SignIn", requestContent);

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();

                var tokenModel= JsonSerializer.Deserialize<JwtResponseModel>(jsonData,new JsonSerializerOptions
                {
                    PropertyNamingPolicy=JsonNamingPolicy.CamelCase,
                });

                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();    

                var token = handler.ReadJwtToken(tokenModel?.Token);

                if (token!=null)
                {
                   //var role = token.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x=>x.Value);

                   // if (role.Contains("Admin"))
                   // {
                   //    redirect
                   // }

                    ClaimsIdentity ıdentity= new ClaimsIdentity(token.Claims,JwtBearerDefaults.AuthenticationScheme);

                    var authProps = new AuthenticationProperties {

                    AllowRefresh = false,

                    ExpiresUtc=tokenModel?.ExpireDate,

                    IsPersistent=true,
                    
                    };

                    await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(ıdentity), authProps);

                    return RedirectToAction("Index","Home");


                }
                else
                {
                    ModelState.AddModelError("", "Kulanıcı Adı Veya Şifre Hatalı");

                    return View(model);
                }

            }
            else
            {
                ModelState.AddModelError("", "Kulanıcı Adı Veya Şifre Hatalı");

                return View(model);
            }

    
        }
    }
}
