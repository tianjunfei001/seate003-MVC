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
        public IActionResult show()
        {
            return View();
        }

        //医院列表
        public IActionResult Hospital_list()
        {
            return View();
        }


        //科室类型
        public IActionResult Hospital_department()
        {
            return View();
        }

        //医生类型
        public IActionResult Hospital_Type()
        {
            return View();
        }


        //主治医生列表
        public IActionResult Hospital_Doctor()
        {
            return View();
        }
        //医生详情表 
        public IActionResult Hospital_DoctorDetails()
        {
            return View();
        }

        //诊断报告

        public IActionResult Diagnostic_Report()
        {
            return View();
        }


        //------------------------------------------------------------------患者管理
        //患者管理
        public IActionResult Patient_Administration()
        {
            return View();
        }
        //患者信息
        public IActionResult Patient_information()
        {
            return View();
        }



        //------------------------------------------------------------------审核管理
        //审核管理-待审批 
        public IActionResult Audit_management()
        {
            return View();
        }
        //审核管理-弹出层
        public IActionResult Audit_managementpop()
        {
            return View();
        }

        //已通过
        public IActionResult Approved()
        {
            return View();
        }
        //已通过-弹出层
        public IActionResult Approvedpop()
        {
            return View();
        }

        //未通过
        public IActionResult Refer()
        {
            return View();
        }
        //未通过-弹出层
        public IActionResult Referpop()
        {
            return View();
        }



        // -------------------goo
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
