using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotIdentity.Models;
using NotIdentity.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NotIdentity.Controllers
{
    public class HomeController : BaseController
    {


        private readonly ILogger<HomeController> _logger;




        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager) : base(userManager, signInManager)
        {


            _logger = logger;


        }

        public IActionResult Index()
        {

            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Member");
            }

            return View();
        }

        public IActionResult Login(string ReturnUrl)
        {

            TempData["ReturnUrl"] = ReturnUrl;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel UserLogin)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByEmailAsync(UserLogin.Email);

                if (user!=null)
                {
                    if (await _userManager.IsLockedOutAsync(user))
                    {
                        ModelState.AddModelError("", "Hesabınız Bir Süreligine Kitlenmiştir. Lütfen Daha Sonra Tekrar Deneyiniz");

                        return View(UserLogin);
                    }




                    // benim yazdıgım cooki varsa onu siler

                    await _signInManager.SignOutAsync();

                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, UserLogin.Password, UserLogin.RememberMe, false);

                    if (result.Succeeded)
                    {
                       await _userManager.ResetAccessFailedCountAsync(user);

                        if (TempData["ReturnUrl"] != null)
                        {
                            return Redirect(TempData["ReturnUrl"].ToString());
                        }
                        return RedirectToAction("Index", "Member");
                    }
                    else
                    {
                        await _userManager.AccessFailedAsync(user);

                        int Fail = await _userManager.GetAccessFailedCountAsync(user);

                        ModelState.AddModelError("", $"{Fail} Kez Başarısız Giriş.");

                        if (Fail==3)
                        {
                            await _userManager.SetLockoutEndDateAsync(user , new System.DateTimeOffset(DateTime.Now.AddMinutes(20)));

                            ModelState.AddModelError("", "Hesabınız 3 Başarısız Girişten Dolayı 20 Dakkika Süre İle Kitlenmiştir Lütfen Daha Sonra Sonra Tekrar Deneyiniz");
                        }
                        else
                        {
                              ModelState.AddModelError("", "Geçersiz Email Adresi Veya Şifresi");
                        }
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Bu Email'e Kayıtlı Kulanıcı Bulunamamıştır");
                }
            }

            return View(UserLogin);
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult >SignUp(UserViewModel userViewModel)
        {

            if (ModelState.IsValid)
            {
                AppUser user = new AppUser();

                user.UserName = userViewModel.UserName;
                user.Email = userViewModel.Email;
                user.PhoneNumber = userViewModel.PhoneNumber;
                IdentityResult result = await _userManager.CreateAsync(user, userViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    AddModelError(result);
                }
            }

            return View(userViewModel);
        }

        public IActionResult ResetPassword()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(PasswordResetViewModel passwordResetViewModel)
        {
          
                AppUser user = _userManager.FindByEmailAsync(passwordResetViewModel.Email).Result;

                if (user != null)

                {
                    string passwordResetToken = _userManager.GeneratePasswordResetTokenAsync(user).Result;

                    string passwordResetLink = Url.Action("ResetPasswordConfirm", "Home", new
                    {
                        userId = user.Id,
                        token = passwordResetToken
                    }, HttpContext.Request.Scheme);

                    //  www.bıdıbıdı.com/Home/ResetPasswordConfirm?userId=sdjfsjf&token=dfjkdjfdjf

                    Helper.PasswordReset.PasswordResetSendEmail(passwordResetLink, user.Email);

                    ViewBag.status = "successful";

                }
                else
                {
                    ModelState.AddModelError("", "Sistemde kayıtlı email adresi bulunamamıştır.");
                }
               
       
           
                return RedirectToAction("ResetPassword");
          
        }
        public IActionResult ResetPasswordConfirm(string userId , string token)
        {

            TempData["UserId"] = userId;

            TempData["Token"] = token;


            return View();
        }

        [HttpPost]

        public async Task<IActionResult> ResetPasswordConfirm([Bind("PasswordNew") ]PasswordResetViewModel passwordResetViewModel)
        {
            string userıd = TempData["UserId"].ToString() ;

            string token = TempData["Token"].ToString();

            AppUser user = await _userManager.FindByIdAsync(userıd);

            if (user!=null)
            {
                IdentityResult result = await _userManager.ResetPasswordAsync(user,token, passwordResetViewModel.PasswordNew);

                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);

                    TempData["PasswordResetİnfo"]="Şifreniz Başarıyla Yenilenmiştir.Yeni Şifreniz İle Giriş Yapabilirsiniz";

                    ViewBag.status="success";
                }
                else
                {
                    AddModelError(result);
                }

            }
            else
            {
                ModelState.AddModelError("", "Bir Hata Meydana Gelmiştir Lütfen Daha Sonra Tekrar Deneyiniz.");
            }


            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
