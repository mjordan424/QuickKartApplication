using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickKartDAL;

namespace QuickKartMVCApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IQuickKartRepository repObj;
        public UserController(IQuickKartRepository quickKartRepo)
        {
            repObj = quickKartRepo;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult ValidateUser(IFormCollection formCollection)
        {
            string email = formCollection["EmailId"];
            string pwd = formCollection["UserPassword"];
            byte returnCode = repObj.ValidateUser(email, pwd);
            if (returnCode == 1)
                return RedirectToAction("Home", "Admin");
            else if (returnCode == 2)
                return RedirectToAction("Home", "Customer");
            else
                return View("Login");

        }
    }
}