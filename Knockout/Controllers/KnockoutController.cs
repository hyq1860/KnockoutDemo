﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockout.Controllers
{
    using Knockout.Models;

    public class KnockoutController : BaseController
    {
        //
        // GET: /Knockout/

        public ActionResult ShoppingCart()
        {
            ViewBag.AutoHtml= ControllerActionCollector.GetControllerNames();
            return View();
        }

        public ActionResult Bank()
        {
            return View();
        }

        public ActionResult HelloWord()
        {
            return View();
        }

        public ActionResult ClickCounter()
        {
            return this.View();
        }

        public ActionResult KnockoutDemo2()
        {
            return this.View();
        }

        public ActionResult ObservableArray()
        {
            return this.View();
        }

        public ActionResult VisibleBinding()
        {
            return this.View();
        }

        public ActionResult TextBinding()
        {
            return this.View();
        }

        public ActionResult HtmlBinding()
        {
            return this.View();
        }

        public ActionResult CssBinding()
        {
            return this.View();
        }

        public ActionResult StyleBinding()
        {
            return this.View();
        }

        public ActionResult AttrBinding()
        {
            return this.View();
        }

        public ActionResult ForeachBinding()
        {
            return this.View();
        }

        public ActionResult ForeachBinding2()
        {
            return this.View();
        }

        public ActionResult ForeachBinding3()
        {
            return this.View();
        }

        public ActionResult ForeachBinding4()
        {
            return this.View();
        }

        public ActionResult ForeachBindingDestroy()
        {
            return this.View();
        }

        public ActionResult ForeachSimpleArray()
        {
            return this.View();
        }

        public ActionResult ForeachListRemove()
        {
            return View();
        }

        public ActionResult ForeachRemoveEvent()
        {
            return View();
        }

        

        public ActionResult IfBinding()
        {
            return this.View();
        }

        public ActionResult WithBinding()
        {
            return this.View();
        }

        public ActionResult JsInteractiveWithBackstage01()
        {
            var products = new List<Product>();
            products.Add(new Product() { Code = "001", Quantity = 1 });
            products.Add(new Product() { Code = "002", Quantity = 1 });
            return this.View(products);
        }

        public ActionResult JsInteractiveWithBackstage02()
        {
            return this.View();
        }

        public ActionResult JsInteractiveWithBackstage02Data()
        {
            var products = new List<Product>();
            products.Add(new Product() { Code = "001", Quantity = 1 });
            products.Add(new Product() { Code = "002", Quantity = 1 });
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        public ActionResult JsSelect()
        {
            return this.View();
        }

        public ActionResult KoMapping()
        {
            return this.View();
        }

        public ActionResult BaiFenBai()
        {
            return this.View();
        }

        public ActionResult SubmitBinding()
        {
            return View();
        }

        public ActionResult ValueBinding()
        {
            return View();
        }

        public ActionResult ValueUpdateBinding()
        {
            return View();
        }

        public ActionResult HasFocusBinding()
        {
            return View();
        }

        public ActionResult CheckboxBinding()
        {
            return View();
        }

        public ActionResult CheckboxArrayBinding()
        {
            return View();
        }

        public ActionResult RadioBinding()
        {
            return View();
        }

        public ActionResult UniqueNameBinding()
        {
            return View();
        }

        public ActionResult IfShowBinding()
        {
            return View();
        }

        public ActionResult test()
        {
            return View();
        }

        public ActionResult ServerPage()
        {
            return View();
        }

        public ActionResult ServerPageData(int pageIndex,int pageSize)
        {
            string[] dataSource = new string[]{
            "越渔船对我船干扰冲撞时倾覆",
            "官员巡山被冲走",
            "申城各界牢记总书记嘱托：一起建设更美好上海",
            "杨雄主持市政府常务会 部署加强气象防灾减灾工作",
            "市民回忆睡在南京路上的战士",
            "探访乌市暴恐分子老家:当地贫困封闭",
            "中国海事局发南海航行警告:船只碰撞频发注意避让",
            "全国政协原副主席马万祺逝世 曾建言在澳门驻军",
            "安徽民政厅回应多名老人自尽:与殡葬改革无关",
            "四川内江一处路段建成通车28个月内夺命43条",
            "甘肃局长疑迷奸女下属 受害者原拟2天后结婚",
            "川岛芳子胞妹去世 被称“清朝最后的格格”(图)",
            "新闻视频：李代沫容留他人吸毒受审 当庭认罪",
            "外媒称朝鲜塌楼超500人遇难 4名负责人被枪毙",
            "事业单位再改革：7月起工资社保向企业看齐",
            "中国电建原副总巨额受贿被双开 曾表示调整自己很痛苦",
            "华电集团云南鲁地拉水电站闸门突然被冲走：投资219亿",
            "“携款5亿出逃”美女老总被诉：真有五亿就不走了",
            "自由软件之父：苹果微软等公司罪大恶极",
            "房企泄密:降价32%仍保本",
            "菲姐范爷时尚头条照抢",
            "李心洁老公飞马来西亚挽救婚姻",
            "昆凌遭周董粉丝炮轰删博",
            "网传王菲新欢男星为吴秀波",
            "四大行超高收益率产品哑火 保5成理财市场主旋律",
            "中小板十年扩容18倍 造千位亿万高管",
            "27日在售高收益银行理财产品",
            "那些一落千丈的股票背后:近半数个股价格不足10元",
            "欧洲议会选举反欧盟之声不绝"
        };
            int count = dataSource.Count();
            List<string> list = dataSource.Skip(pageIndex * pageSize).Take(pageSize).ToList();
            var data = new
            {
                count = count,
                list = list
            };
            var jsonData = new JsonResult { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
            return jsonData;
        }

        public ActionResult UpdateOneInCollection()
        {
            return View();
        }

        public ActionResult TemplateBinding1()
        {
            return View();
        }

        public ActionResult TemplateBinding2()
        {
            return View();
        }

        public ActionResult TemplateBinding3()
        {
            return View();
        }

        public ActionResult ClickToEdit()
        {
            return View();
        }

        public ActionResult CustomBinding()
        {
            return View();
        }

        public ActionResult ComponentBinding()
        {
            return View();
        }

        public ActionResult TheDataBindSyntax()
        {
            return View();
        }

        public ActionResult BindingContext()
        {
            return View();
        }

        public ActionResult BindSame()
        {
            return View();
        }

        public ActionResult KnockoutExtension()
        {
            return View();
        }

        public ActionResult ScrollToButtom()
        {
            return View();
        }

        public ActionResult MicroStoreDemo()
        {
            return View();
        }

        public ActionResult MicroStoreModuleDemo()
        {
            return View();
        }

        public ActionResult ForeachListSplice()
        {
            return View();
        }

        public ActionResult SortableArray()
        {
            return View();
        }
    }
}
