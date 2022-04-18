using Microsoft.AspNetCore.Mvc;
using RaellShoes.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaellShoes.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Index(LoginViewModel admin)
        {
            if (!admin.Admin)
            {
                return RedirectToAction("Index", "home");
            }
            return View();
        }
    }
}
