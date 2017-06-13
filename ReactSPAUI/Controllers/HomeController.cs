using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using ReactSPACore.Data;
using ReactSPACore.Service;
using ReactSPALogic.Test;

namespace ReactSPAUI.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment host = null;
        private IDapper dapper = null;

        public HomeController(IHostingEnvironment env, IDapper _dapper)
        {
            host = env;
            dapper = _dapper;
        }
        public IActionResult Index()
        {
            SqliteConnectionStringBuilder sb = new SqliteConnectionStringBuilder();
            sb.DataSource = Path.Combine(host.ContentRootPath, "DB/reactspa.db");
            var result = ServiceProvider.GetService<IDapper>().GetList<ReactSPAModel.Test.Film>(sb.ToString(), "select * from film", null);
            // var result = dapper.GetList<ReactSPAModel.Test.Film>(sb.ToString(), "select * from film", null);
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
