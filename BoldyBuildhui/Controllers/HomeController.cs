using BoldyBuildhui.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BoldyBuildhui.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string fileName = @"E:\Programming\Projects\webhueb\BoldyBuildhui\BoldyBuildhui\App_Data\champion.json";
            List<ChampionMini> championsList = JsonConvert.DeserializeObject<RootDTO<ChampionMini>>(fileName).Data.Values.ToList();
            ViewBag.Champions = championsList;

            return View();

        }

        
        public ActionResult Champion(string id)
        {
            Debug.WriteLine($"ID IS {id} NOW");
            WebRequest request = WebRequest.Create($"http://ddragon.leagueoflegends.com/cdn/8.20.1/data/en_US/champion/{id}.json");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string championData = reader.ReadToEnd();
            reader.Close();
            ChampionMini champ = JsonConvert.DeserializeObject<RootDTO<ChampionMini>>(championData).Data[id];
            return View(champ);
        }

    }
}