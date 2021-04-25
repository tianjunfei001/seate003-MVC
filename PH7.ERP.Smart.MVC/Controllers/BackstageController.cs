using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PH7.ERP.Smart.MVC.Controllers
{
    public class BackstageController : Controller
    {
        //后台管理页面
        public IActionResult Index()
        {
            return View();
        }
    }
}
