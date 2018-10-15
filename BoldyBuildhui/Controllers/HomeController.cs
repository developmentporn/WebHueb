using BoldyBuildhui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoldyBuildhui.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Item()
        {
            
            RootItem ri = Serializer.deserialize<RootItem>(@"E:\Programming\Projects\webhueb\BoldyBuildhui\BoldyBuildhui\App_Data\item.json");

            var itemList = ri.Data.Values.ToList();
            return View(itemList);
        }

        public ActionResult Champion()
        {
            RootChampion rc = Serializer.deserialize<RootChampion>(@"E:\Programming\Projects\webhueb\BoldyBuildhui\BoldyBuildhui\App_Data\champion.json");

            var championList = rc.Data.Values.ToList();
            return View(championList);
        }
    }
}