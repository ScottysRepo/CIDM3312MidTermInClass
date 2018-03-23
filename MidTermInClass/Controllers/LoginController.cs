using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidTerm.Models;
using Midterm.Models;


namespace Midterm.Controllers
{
    public class LoginController : Controller
    {
                [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckLogin(LoginViewModel login)
        {
            if (ModelState.IsValid){
                if (login.Username == "MyUser" && login.Password == "Default")
                {
                    return View("Successful");
                }
                else
                {
                    return View("Unsuccessful");
                }
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult Successful()
        {
            return View();
        }

        public IActionResult Unsuccessful()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel login)
        {
            Repository.AddLogin(login);
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}