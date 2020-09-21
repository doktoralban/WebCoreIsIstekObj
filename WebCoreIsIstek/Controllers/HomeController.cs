using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCoreIsIstek.Infrastructure.Data;
using WebCoreIsIstek.Infrastructure.Repository;
using ur = WebCoreIsIstek.Infrastructure.Repository;
using dt = WebCoreIsIstek.Infrastructure.Data;

namespace WebCoreIsIstek.Controllers
{
    public class HomeController : Controller
    {
        public   IActionResult Index()
        {        
            return View();
        }
    }
}
