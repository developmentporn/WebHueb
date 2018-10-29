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
            string fileName = @"E:\Programming\Projects\webhueb\lulkek\BoldyBuildhui\App_Data\champion.json";
            List<ChampionMini> championsList = new List<ChampionMini>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string championData = reader.ReadToEnd();
                championsList = JsonConvert.DeserializeObject<RootDTO<ChampionMini>>(championData).Data.Values.ToList();
            }
            ViewBag.Version = DataDragon.Version;
            ViewBag.Champions = championsList;

            return PartialView();

        }

        
        public ActionResult ChampionPartial(string id)
        {
            Debug.WriteLine($"ID IS {id} NOW");
            WebRequest request = WebRequest.Create($"http://ddragon.leagueoflegends.com/cdn/8.20.1/data/en_US/champion/{id}.json");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string championData = reader.ReadToEnd();
            reader.Close();
            string filename = @"E:\Programming\Projects\webhueb\lulkek\BoldyBuildhui\App_Data\item.json";
            reader = new StreamReader(filename);
            string itemsData = reader.ReadToEnd();
            var items = JsonConvert.DeserializeObject<RootDTO<Item>>(itemsData).Data;
            Champion champ = JsonConvert.DeserializeObject<RootDTO<Champion>>(championData).Data[id];
            champ.Inventory[0] = items["1001"];
            ViewBag.Items = items;
            return PartialView(champ);
        }

    }
}