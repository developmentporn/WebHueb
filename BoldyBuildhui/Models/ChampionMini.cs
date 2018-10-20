using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace BoldyBuildhui.Models
{
    public class ChampionMini
    {
        public string Id { get; set; }
        public int Key { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }        
        public Image Image { get; set; }            
    }

    
}