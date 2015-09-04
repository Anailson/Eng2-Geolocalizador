using Geolocalizador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Security.Claims;

namespace Geolocalizador.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<MyIdentityUser> userManager;
        private RoleManager<MyIdentityRole> roleManager;


        public AccountController()
        {
            MyIdentityDbContext db = new MyIdentityDbContext();
            UserStore<MyIdentityUser> userStore = new UserStore<MyIdentityUser>(db);
            userManager = new UserManager<MyIdentityUser>(userStore);

            RoleStore<MyIdentityRole> roleStore = new RoleStore<MyIdentityRole>(db);
            roleManager = new RoleManager<MyIdentityRole>(roleStore);
        }


        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                MyIdentityUser user = new MyIdentityUser();
                user.UserName = model.UserName;
                user.Email = model.Email;
                user.FullName = model.FullName;
                user.BirthDate = model.BirthDate;
                user.Bio = model.Bio;

                IdentityResult result = userManager.Create(user, model.Password);

                if (result.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Administrator");
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("UserName", "Erro na criação do usuário");
                }
            }
            return View(model);
        }

        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                MyIdentityUser user = userManager.Find(model.UserName, model.Password);
                if (user != null)
                {
                    IAuthenticationManager authManager = HttpContext.GetOwinContext().Authentication;
                    authManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
                    ClaimsIdentity identity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthenticationProperties props = new AuthenticationProperties();
                    props.IsPersistent = model.Rememberme;
                    authManager.SignIn(props, identity);

                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Usuário ou senha inválido");
                }
            }
            return View(model);
        }

        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ChangePassword model)
        {
            if (ModelState.IsValid)
            {
                MyIdentityUser user = userManager.FindByName(HttpContext.User.Identity.Name);
                IdentityResult result = userManager.ChangePassword(user.Id, model.OldPassword, model.NewPassword);
                if (result.Succeeded)
                {
                    IAuthenticationManager authManager = HttpContext.GetOwinContext().Authentication;
                    authManager.SignOut();
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Erro na mudança da senha");
                }
            }
            return View(model);
        }


        [Authorize]
        public ActionResult ChangeProfile()
        {
            MyIdentityUser user = userManager.FindByName(HttpContext.User.Identity.Name);
            ChangeProfile model = new ChangeProfile();
            model.FullName = user.FullName;
            model.BirthDate = user.BirthDate;
            model.Bio = user.Bio;
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeProfile(ChangeProfile model)
        {
            if (ModelState.IsValid)
            {
                MyIdentityUser user = userManager.FindByName(HttpContext.User.Identity.Name);
                user.FullName = model.FullName;
                user.BirthDate = model.BirthDate;
                user.Bio = model.Bio;
                IdentityResult result = userManager.Update(user);

                if (result.Succeeded)
                {
                    ViewBag.Message = "Perfil alterado com sucesso";
                }
                else
                {
                    ModelState.AddModelError("", "Erro na alteração do perfil");
                }
            }
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOut()
        {
            IAuthenticationManager authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            return RedirectToAction("Login", "Account");
        }

    }
}