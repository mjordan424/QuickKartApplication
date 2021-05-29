using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QuickKartMVCApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}