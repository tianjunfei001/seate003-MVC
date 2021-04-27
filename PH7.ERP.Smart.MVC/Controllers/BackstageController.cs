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
        //账号医生管理
        public IActionResult Account()
        {
            return View();
        }
        //账号医生管理添加
        public IActionResult Add()
        {
            return View();
        }
        //账号患者管理
        public IActionResult Patient()
        {
            return View();
        }
        //账号患者修改
        public IActionResult Upd()
        {
            return View();
        }
    }
}
