using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DoneIt.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Signin()
        {
            return View();
        }
    }
}