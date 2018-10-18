using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoldyBuildhui.Models
{
    public class Spell
    {
        public class SpellVar
        {
            public string Link { get; set; }
            public double Coeff { get; set; }
            public string Key { get; set; }
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tooltip { get; set; }
        public List<double> Cooldown { get; set; }
        public string CooldownBurn { get; set; }
        public List<int> Cost { get; set; }
        public string CostBurn { get; set; }
        public List<string> EffectBurn { get; set; }
        public List<SpellVar> Vars { get; set; }
        public List<int> Range { get; set; }
        public Image Image { get; set; }
    }
}