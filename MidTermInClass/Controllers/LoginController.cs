using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Login.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult _LoginLayout()
        {
            return View();
        }
           public IActionResult LoginSuccessful()
        {
            return View();
        }
                public IActionResult LoginUnsuccessful()
        {
            return View();
        }
    }
}