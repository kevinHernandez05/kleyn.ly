using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Kleyn.ly.Controllers
{
    public class URLController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
