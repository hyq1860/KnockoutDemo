using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Knockout.Controllers
{
    public class ControllerActionCollector
    {
        //获取某一个程序集下所有的类　　  
        private static List<Type> GetSubClasses<T>()
        {
            return Assembly.GetCallingAssembly().GetTypes().Where(
                type => type.IsSubclassOf(typeof(T))).ToList();
        }

        private static List<MethodInfo> GetSubMethods(Type t)
        {
            return t.GetMethods().Where(m => (m.ReturnType == typeof(ActionResult) || m.ReturnType == typeof(JsonResult)) && m.IsPublic == true).ToList();
        }

        public static string GetControllerNames()
        {
            var sb = new StringBuilder();
            foreach (var t in GetSubClasses<Controller>())
            {
                var controllerFunction = t.GetCustomAttributes(true);
                var controller = t.Name.Replace("Controller","");
                List<MethodInfo> mfCollection = GetSubMethods(t);
                
                foreach (MethodInfo methodInfo in mfCollection)
                {
                    var actionName = methodInfo.Name;
                    sb.AppendFormat("<a href=\"{0}/{1}\">{1}</a><br/>", controller, actionName);
                }

                //mfCollection.ForEach(method => controllerNames.Add("---" + method.Name));
            }
            return sb.ToString();
        }
    }
}