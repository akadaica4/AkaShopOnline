using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.WebApp.Controllers.Components
{
    public class ProductController : Controller
    {
        public IActionResult Detail(int id)
        {
            return View();
        }

        public IActionResult Category(int id)
        {
            return View();
        }
    }
}

