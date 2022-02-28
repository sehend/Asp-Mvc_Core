using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using NotIdentity.Enams;
using NotIdentity.Models;
using NotIdentity.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Users;

namespace NotIdentity.Controllers
{
    [Authorize]
    public class MemberController : BaseController
    {
        private readonly ILogger<MemberController> _logger;

   

        public MemberController(ILogger<MemberController> logger, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager):base(userManager, signInManager,null)
        {
            _logger = logger;

         
        }

       
        public IActionResult Index()
        {

            AppUser user = CurrentUser;


            UserViewModel userViewModel = user.Adapt<UserViewModel>();

            return View(userViewModel);
        }

        public  IActionResult UserEdit()
        {
            AppUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            UserViewModel userViewModel = user.Adapt<UserViewModel>();

            ViewBag.Gender = new SelectList(Enum.GetNames(typeof(Gender)));

            return View(userViewModel);
        }

      [HttpPost]
        public async Task<IActionResult> UserEdit(UserViewModel userViewModel, IFormFile Sehned)
        {
            
            ModelState.Remove("Password");
            ViewBag.Gender = new SelectList(Enum.GetNames(typeof(Gender)));
            if (ModelState.IsValid)
            {
                AppUser user = CurrentUser;

                string phone = _userManager.GetPhoneNumberAsync(user).Result;

                if (phone != userViewModel.PhoneNumber)
                {
                    if (_userManager.Users.Any(u => u.PhoneNumber == userViewModel.PhoneNumber))
                    {
                        ModelState.AddModelError("", "Bu telefon numarası başka üye tarafından kullanılmaktadır.");
                        return View(userViewModel);
                    }
                }

                if (Sehned != null && Sehned.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(Sehned.FileName);

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserPicture", fileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await Sehned.CopyToAsync(stream);

                        user.Picture = "/UserPicture/" + fileName;
                    }
                }

                user.UserName = userViewModel.UserName;
                user.Email = userViewModel.Email;
                user.PhoneNumber = userViewModel.PhoneNumber;

                user.City = userViewModel.Ctiy;

                user.BirthDay = userViewModel.Birthday;

                user.Gender = (int)userViewModel.Gneder;

                IdentityResult result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(user, true);

                    ViewBag.success = "true";
                }
                else
                {
                    AddModelError(result);
                }
            }

            return View(userViewModel);
        }
        public IActionResult PasswordChange()
        {

            return View();
        }

        [HttpPost]
        public IActionResult PasswordChange(PasswordChangeViewModel passwordChangeViewModel)
        {

            if (ModelState.IsValid)
            {
                AppUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;

                if (user!=null)
                {
                    bool exist = _userManager.CheckPasswordAsync(user, passwordChangeViewModel.PasswordOld).Result;

                    if (exist==true)
                    {
                        IdentityResult result = _userManager.ChangePasswordAsync(user, passwordChangeViewModel.PasswordOld,passwordChangeViewModel.PasswordNew).Result;

                        if (result.Succeeded)
                        {
                            _userManager.UpdateSecurityStampAsync(user);

                            /*cooki yileme 2 satır*/

                            _signInManager.SignOutAsync();

                            _signInManager.PasswordSignInAsync(user, passwordChangeViewModel.PasswordNew,true,false);



                            ViewBag.success = "true";
                        }
                        else
                        {
                            foreach (var item in result.Errors)
                            {
                                ModelState.AddModelError("", item.Description);
                            }
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("","Eski Şifreniz Yanlış");
                    }
                }
            }


            return View(passwordChangeViewModel);
        }
        public IActionResult Logout()
        {

            _signInManager.SignOutAsync();

            return RedirectToAction("Index","Home");
        }

       [Authorize(Roles ="Editör")]
        public IActionResult Editor()
        {
            return View();
        }

        [Authorize(Roles = "Manager")]
        public IActionResult Manager()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }



    }
}
