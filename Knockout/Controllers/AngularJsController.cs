using Knockout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockout.Controllers
{
    public class AngularJsController : BaseController
    {

        public ActionResult Start()
        {
            return View();
        }

        public ActionResult Mvc01()
        {
            return View();
        }

        public ActionResult Binding()
        {
            return View();
        }

        public ActionResult UseController()
        {
            return View();
        }

        public ActionResult ScopeVarFunction()
        {
            return View();
        }

        public ActionResult UseService()
        {
            return View();
        }

        public ActionResult UseServiceShareDataInController()
        {
            return View();
        }

        public ActionResult Keyword()
        {
            return View();
        }

        public ActionResult UseHttp()
        {
            return View();
        }

        public class Province
        {
            public string Id { get; set; }

            public string Name { get; set; }
        }

        public ActionResult HttpData(string t)
        {
            var result = new JsonResult();
            result.JsonRequestBehavior=JsonRequestBehavior.AllowGet;
            var data = new Result<List<Province>>();
            data.Data = new List<Province>();
            data.Data.Add(new Province { Id = "6", Name = "中国a股" });
            data.Data.Add(new Province { Id = "7", Name = "中国港股" });
            
            //throw new Exception();
            if(t=="no")
            {
                data.Code = "-1";
                data.Message = "没有权限";
            }
            else
            {
                data.Code = "1";
            }
            result.Data = data;
            return result;
        }

        public ActionResult UseDirective()
        {
            return View();
        }

        public ActionResult UseModule()
        {
            return View();
        }

        public ActionResult UseFilter()
        {
            return View();
        }

        public ActionResult UseExpressions()
        {
            return View();
        }

        public ActionResult UseProvider()
        {
            return View();
        }

        public ActionResult UseUiRouter()
        {
            return View();
        }

        public ActionResult UseUiRouter_MultipleNamedViews()
        {
            return View();
        }

        public ActionResult UseUiRouter_URLRouting()
        {
            return View();
        }

        public ActionResult AngularJS_ui_router_StateManager()
        {
            return View();
        }

        public ActionResult AngularJS_ui_router_URL_Routing()
        {
            return View();
        }

        public ActionResult AngularExecuteOrder()
        {
            return View();
        }


        public ActionResult NestedViews()
        {
            return View();
        }

        public ActionResult CommonDirective()
        {
            return View();
        }

        public ActionResult NgRepeatFinishCallback()
        {
            return View();
        }

        public ActionResult UseHttpInterceptors()
        {
            return View();
        }

        public ActionResult AngularJSEasyUI()
        {
            return View();
        }

        public ActionResult AngularJS_ngGrid()
        {
            return View();
        }

        public ActionResult AngularJS_SmartTable01()
        {
            return View();
        }

        public ActionResult AngularJS_Timeout()
        {
            return View();
        }

        public ActionResult AngularJS_PageLikeGoogle()
        {
            return View();
        }

        public ActionResult AngularJS_ngOption()
        {
            return View();
        }

        public ActionResult AngularJS_JS_Set_App()
        {
            return View();
        }

        public ActionResult AngularJS_Form()
        {
            return View();
        }

        public ActionResult AngularJS_NestedController()
        {
            return View();
        }
    }
}
