using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalizationAndLocalization.Filters
{
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.Controller.ViewBag.ExceptionMessage = "Custom Exception: Message from OnException method.";
            Debug.WriteLine("Custom Exception: Message from OnException method.");
        }
    }
}