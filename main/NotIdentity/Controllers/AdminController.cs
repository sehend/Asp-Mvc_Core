using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NotIdentity.Models;
using NotIdentity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotIdentity.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {



        public AdminController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager) : base(userManager,null,roleManager)
        {
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Roles()
        {
            return View(_roleManager.Roles.ToList());
        }
        public IActionResult RolCreat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RolCreat(RoleViewModels roleViewModels)
        {

            AppRole Role = new AppRole();

            Role.Name = roleViewModels.Name;

            IdentityResult result = _roleManager.CreateAsync(Role).Result;

            if (result.Succeeded)
            {
                return RedirectToAction("Roles");
            }
            else
            {
                AddModelError(result);
            }

            return View(roleViewModels);
        }


     
        public IActionResult RoleDelete(string id)
        {
            AppRole role = _roleManager.FindByIdAsync(id).Result;

            if (role != null)
            {
                IdentityResult result = _roleManager.DeleteAsync(role).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Roles");
                }
                else
                {
                    ViewBag.error = "Bir Hata Meydana Geldi";
                }
            }

            return View();
        }

        public IActionResult RolApdate(string id)
        {

            AppRole role = _roleManager.FindByIdAsync(id).Result;

            return View(role.Adapt<RoleViewModels>());

        }

        [HttpPost]
        public IActionResult RolApdate(RoleViewModels roleViewModels)
        {

            AppRole role = _roleManager.FindByIdAsync(roleViewModels.Id).Result;

            if (role != null)
            {
                role.Name = roleViewModels.Name;

                IdentityResult result = _roleManager.UpdateAsync(role).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Roles");
                }
                else
                {
                    AddModelError(result);
                }

            }
            else
            {
                ModelState.AddModelError("", "Günceleme İşlemi Başarısız oldu");
            }

            return View(roleViewModels);
        }

        public  IActionResult RoleAssign(string id)
        {
            TempData["userId"] = id;

            AppUser user = _userManager.FindByIdAsync(id).Result;

            ViewBag.userName = user.UserName;

            IQueryable<AppRole> roles = _roleManager.Roles;

            /*  kest işlemi as ile başlayayan  */

            List<string> userRoles = _userManager.GetRolesAsync(user).Result as List<string>;

            List<RoleAssignViewModel> roleAssignViewModels = new List<RoleAssignViewModel>();

            foreach (var role in roles)
            {
                RoleAssignViewModel r = new RoleAssignViewModel();
                r.RoleId = role.Id;
                r.RoleName = role.Name;
                if (userRoles.Contains(role.Name))
                {
                 
                    r.Exist = true;
                }
                else
                {
                  
                    r.Exist = false;
                }

                roleAssignViewModels.Add(r);
            }

            return View(roleAssignViewModels);

        }
        [HttpPost]
        public async Task<IActionResult> RoleAssign(List<RoleAssignViewModel> roleAssignViewModels)
        {
            AppUser user = _userManager.FindByIdAsync(TempData["userId"].ToString()).Result;

            foreach (var item in roleAssignViewModels)
            {
                if (item.Exist)

                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);
                }
            }

            return RedirectToAction("Users");
        }



        public IActionResult Users()
        {

       

            return View(_userManager.Users.ToList());
        }

        

    }
}
