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
            return View();
        }

        /// <summary>
        /// 接诊台，接诊管理;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
        /// </summary>
        /// <returns></returns>
        //接诊台默认未接诊
        public IActionResult Patient_Administration()
        {
            return View();
        }

        //未接诊页点击接诊
        public IActionResult Patient_Treat()
        {
            return View();
        }
        //患者诊断 已接诊
        public IActionResult Patient_Adminyes()
        {
            return View();
        }

        //患者信息 诊断管理
        public IActionResult Patient_Diagnostic()
        {
            return View();
        }

        //诊断列表
        public IActionResult Patient_Dialist()
        {
            return View();
        }

        //诊断报告反填
        public IActionResult Patient_Backfill()
        {
            return View();
        }

        //评价
        public IActionResult Patient_Gdnum()
        {
            return View();
        }
    }
}
