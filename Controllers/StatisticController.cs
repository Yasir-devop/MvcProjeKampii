using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        Context context = new Context();
        
        public ActionResult Index()
        {
            var queryResult = context.Categories.Count().ToString();
            ViewBag.viewbag = queryResult;

            var queryResult1 = context.Headings.Count(c => c.CategoryID == 15).ToString();
            ViewBag.viewbag1 = queryResult1;

            
            var queryResult2 = context.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.viewbag2 = queryResult2;


            
            var queryResult3 = context.Headings.Max(x => x.Category.CategoryName);
            ViewBag.viewbag3 = queryResult3;

            var result4 = context.Categories.Count(x => x.CategoryStatus == false) - context.Categories.Count(x => x.CategoryStatus == true);
            ViewBag.viewbag4 = result4;
            return View();
        }
    }
}