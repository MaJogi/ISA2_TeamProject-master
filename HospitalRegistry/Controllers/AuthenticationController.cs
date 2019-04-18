using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Core;
using Infra;
using Microsoft.AspNetCore.Mvc;

namespace HospitalRegistry.Controllers
{
    public class AuthenticationController : Controller //Started doing authenticationcontroller and noticed it was already done by the visual studio.
    {
    //    public ActionResult Login()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> DoLogin(UserDetails u)
    //    {
    //        if(Patients.IsValidUser(u))
    //        {
    //            await setIdentity(u);
    //            return RedirectToAction("Index", "Patient");
    //        }
    //        ModelState.AddModelError("CredentialError", "Invalid Username or Password");
    //        return View("Login");
    //    }

    //    private async Task setIdentity(UserDetails u)
    //    {
    //        List<Claim> claims = new List<Claim> {new Claim(ClaimTypes.Name, u.UserName )};
    //        ClaimsIdentity identity = new ClaimIdentity(claims, "cookie");
    //        ClaimsPrincipal principal = new ClaimsPrincipals(identity);
    //        await HttpContext.SingInAsync(
    //            scheme: "AuthScheme",
    //            principal: principal);
    //    }
    }
}