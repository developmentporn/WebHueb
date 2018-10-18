using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoldyBuildhui.Models
{
    public class Champion : ChampionMini
    {
        public class ChampionInfo
        {
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int Magic { get; set; }
            public int Difficulty { get; set; }
        }

        public class ChampionStats
        {
            public double Hp { get; set; }
            public double HpPerLevel { get; set; }
            public double Mp { get; set; }
            public double MpPerLevel { get; set; }
            public double MoveSpeed { get; set; }
            public double Armor { get; set; }
            public double ArmorPerLevel { get; set; }
            public double SpellBlock { get; set; }
            public double SpellBlockPerLevel { get; set; }
            public int AttackRange { get; set; }
            public double HpRegen { get; set; }
            public double HpRegenPerLevel { get; set; }
            public double MpRegen { get; set; }
            public double MpRegenPerLevel { get; set; }
            public double Crit { get; set; }
            public double CritPerLevel { get; set; }
            public double AttackDamage { get; set; }
            public double AttackDamagePerLevel { get; set; }
            public double AttackSpeedOffset { get; set; }
            public double AttackSpeedPerLevel { get; set; }
        }

        public string Partype { get; set; }
        public ChampionInfo Info { get; set; }
        public ChampionStats Stats { get; set; }
        public List<Spell> Spells { get; set; }
    }
}