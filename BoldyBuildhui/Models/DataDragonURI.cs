using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace BoldyBuildhui.Models
{
    public class DataDragon
    {
        static readonly public string URI = "http://ddragon.leagueoflegends.com";

        static readonly public string PREFIX = $"/cdn/{Version}/data/en_US/";
        static readonly public string CHAMPIONS = PREFIX + "champion.json";        
        static readonly public string CHAMPIONS_FULL = PREFIX + "championFull.json";
        static readonly public string ITEMS = PREFIX + "item.json";
        static readonly public string RUNES = PREFIX + "runesReforged.json";
        static readonly public string SUMMONNER_SPELLS = PREFIX + "summoner.json";

        static readonly public string VERSIONS = "/api/versions.json";

        static public string Version
        {
            get
            {
                WebRequest request = WebRequest.Create(URI + VERSIONS);
                WebResponse response = request.GetResponse();
                Stream streamData = response.GetResponseStream();
                StreamReader sr = new StreamReader(streamData);
                string versionsData = sr.ReadToEnd();
                string currentVersion = JsonConvert.DeserializeObject<List<string>>(versionsData)[0];
                return currentVersion;
            }            
        }
    }
}