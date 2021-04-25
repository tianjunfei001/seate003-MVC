using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PH7.ERP.Smart.MVC.Controllers
{
    public class DoctorController : Controller
    {
        //医生端管理页面
        public IActionResult Index()
        {
            return View();
        }

        //医生端账户密码登录页面
        public IActionResult DoctorLogShow()
        {
            return View();
        }
        //医生端手机登录页面
        public IActionResult DoctorLogCellShow()
        {
            return View();
        }

        //医生端注册页面
        public IActionResult DoctorZhuciShow()
        {
            return View();
        }



        //测试页面后台管理
        public IActionResult CeiHoutai()
        {
            return View();
        }
      
        //测试医生端
        public IActionResult CeiYisheng()
        {
            int a = 1;
            return View();
        }
    }
}
