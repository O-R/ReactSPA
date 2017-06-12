using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ReactSPALogic.Test;

namespace ReactSPAUI.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment host = null;

        public HomeController(IHostingEnvironment env)
        {
            host = env;
        }
        public IActionResult Index()
        {
            new FilmLogic().test(Path.Combine(host.ContentRootPath, "DB/reactspa.db"));
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
