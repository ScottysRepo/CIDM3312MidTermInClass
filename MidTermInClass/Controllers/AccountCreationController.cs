using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Models;
using Midterm.Controllers;

namespace Midterm.Controllers
{
    public class AccountCreationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      public IActionResult Validation(AccountCreate createAccount)
        {
            if(ModelState.IsValid){
                string[] EmailParts = createAccount.Email.Split(new char[]{' '});

                for (int i = 0; i < createAccount.Email.Length; i++)
                {
                    if (createAccount.Email[i] == '@' && createAccount.Password.Length >= 8)
                    {
                        return View("AccountCreate");
                    }
                }
            }
            else
            {
                return View("Error");
            }
            return View("AccountFail");
        }


    }
}
