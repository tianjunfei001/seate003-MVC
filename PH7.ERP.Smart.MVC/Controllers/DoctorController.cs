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

        //----------------------tjf
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
        //----------------------------------------------

       

        /// <summary>
        /// 接诊台，接诊管理;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
        /// </summary>
        /// <returns></returns>
        //接诊台默认未接诊
        public IActionResult Patient_Administration()
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
        public IActionResult Patient_Acclaim()
        {
            return View();
        }

        //评价多表
        public IActionResult Patient_Acclaimss()
        {
            return View();
        }

        //接诊改
        public IActionResult Patient_Treat()
        {
            return View();
        }








        // -----------------------------sunyaooqi

        //
        /// <summary>
        /// 医生端个人信息视图  --信息
        /// </summary>
        /// <returns></returns>
        public IActionResult GetInformation()
        {
            return View();
        }
        /// <summary>
        /// 医生端修改密码信息视图  --密码图
        /// </summary>
        /// <returns></returns>
        public IActionResult Ciphermap()
        {
            return View();
        }
        /// <summary>
        /// 医生端修改用户密码信息视图  --用户密码
        /// </summary>
        /// <returns></returns>
        public IActionResult GetUserPassword()
        {
            return View();
        }

        /// <summary>
        /// 接诊台视图  --站台
        /// </summary>
        /// <returns></returns>
        public IActionResult Platform()
        {
            return View();
        }

        /// <summary>
        /// 医生端诊断管理视图  --接诊金额
        /// </summary>
        /// <returns></returns>
        public IActionResult ReceptionAmount()
        {
            return View();
        }
        /// <summary>
        /// 医生端诊断管理查看视图  --诊断详情
        /// </summary>
        /// <returns></returns>
        public IActionResult DiagnosticDetails()
        {
            return View();
        }


        //----------------钱包   caj
        //我的钱包界面
        public IActionResult DoctorWallet()
        {
            return View();
        }
        //钱包绑卡界面
        public IActionResult TiedCard()
        {
            return View();
        }
        //手机预留页面
        public IActionResult MobilePhone()
        {
            return View();
        }
        //提现选卡页面
        public IActionResult SelectBankCard()
        {
            return View();
        }
        //提现金额界面
        public IActionResult WithdrawDeposit()
        {
            return View();
        }

    }
}
