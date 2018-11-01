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
            private Champion parent;

            public ChampionStats(Champion parent)
            {
                this.parent = parent;
            }

            private int _Level;
            public int Level { get; set; }

            //Primary stats
            private double _Hp;
            private double _Mp;
            private double _MoveSpeed;
            private double _Armor;
            private double _SpellBlock;            
            private double _Crit;
            private double _AttackDamage;
            private double _AbilityPower;
            private double _AttackSpeed;
            private double _AttackSpeedOffset;
            private double _CooldownReduction;

            //Primary stats properties
            public double HpPerLevel { get; set; }
            public double MpPerLevel { get; set; }
            public double ArmorPerLevel { get; set; }
            public double SpellBlockPerLevel { get; set; }         
            public double Crit { get; set; }
            public double CritPerLevel { get; set; }
            public double AttackDamagePerLevel { get; set; }
            public double AttackSpeedPerLevel { get; set; }
            public double AbilityPower { get; set; }
            public double CooldownReduction { get; set; }
            

            public double Hp
            {
                get
                {
                    return CalculateStat(_Hp, HpPerLevel);
                }
                set { _Hp = value; }
            }

            public double Mp
            {
                get { return CalculateStat(_Mp, MpPerLevel); }
                set { _Mp = value; }
            }

            public double MoveSpeed
            {
                get
                {
                    //double itemsStat = 0;
                    //foreach (var item in parent.Inventory)
                    //{
                    //    if (item != null)
                    //    {
                    //        itemsStat += item.Stats.FlatMovementSpeedMod;
                    //    }
                    //}

                    return _MoveSpeed + CollectStatValues("FlatMovementSpeedMod");
                }
                set { _MoveSpeed = value; }
            }

            public double Armor
            {
                get { return CalculateStat(_Armor, ArmorPerLevel); }
                set { _Armor = value; }
            }

            public double SpellBlock
            {
                get { return CalculateStat(_SpellBlock, SpellBlockPerLevel); }
                set { _SpellBlock = value; }
            }

            public double AttackDamage { get => CalculateStat(_AttackDamage, AttackDamagePerLevel); set => _AttackDamage = value; }
            public double AttackSpeedOffset
            {
                get => _AttackSpeedOffset;
                set
                {
                    this._AttackSpeedOffset = value;
                    this._AttackSpeed = 0.625 / (1 + _AttackSpeedOffset);
                }
            }

            public double AttackSpeedPercentage { get => (AttackSpeedPerLevel * (0.0175 * (Level * Level - 1) + 0.6675 * (Level - 1))) / 100; }            

            public double AttackSpeed { get => _AttackSpeed + (_AttackSpeed * AttackSpeedPercentage); }

            //Secondary stats
            private double _HpRegen;
            private double _MpRegen;
            private double _Lethality;
            private double _ArmorPenetration;
            private double _MagicPenetration;
            private double _MagicPenetrationPercentage;
            private double _LifeSteal;
            private double _SpellVamp;
            private int _AttackRange;
            private double _Tenacity;

            //Secondary stats properties
            public double HpRegenPerLevel { get; set; }            
            public double MpRegenPerLevel { get; set; }
            public double Lethality { get => _Lethality; set => _Lethality = value; }
            public double ArmorPenetration { get => _ArmorPenetration; set => _ArmorPenetration = value; }
            public double MagicPenetration { get => _MagicPenetration; set => _MagicPenetration = value; }
            public double MagicPenetrationPercentage { get => _MagicPenetrationPercentage; set => _MagicPenetrationPercentage = value; }
            public double LifeSteal { get => _LifeSteal; set => _LifeSteal = value; }
            public double SpellVamp { get => _SpellVamp; set => _SpellVamp = value; }
            public int AttackRange { get => _AttackRange; set => _AttackRange = value; }
            public double Tenacity { get => _Tenacity; set => _Tenacity = value; }
            public double HpRegen
            {
                get { return CalculateStat(_HpRegen, HpRegenPerLevel); }
                set { _HpRegen = value; }
            }
            public double MpRegen
            {
                get { return CalculateStat(_MpRegen, MpRegenPerLevel); }
                set { _MpRegen = value; }
            }
                        
            //Utility methods
            private double CalculateStat(double baseValue, double growthValue)
            {
                return baseValue + growthValue * (Level - 1) * (0.7025 + 0.0175 * (Level - 1));
            }

            private double CollectStatValues(string statName)
            {
                double itemStat = 0;
                foreach(var item in parent.Inventory)
                {
                    if (item != null)
                        itemStat += (double)typeof(Item.ItemStats).GetProperty(statName).GetValue(item.Stats);
                }
                
                return itemStat;
            }
        }

        public string Partype { get; set; }
        public ChampionInfo Info { get; set; }
        public ChampionStats Stats { get; set; }
        public List<Spell> Spells { get; set; }
        public Item[] Inventory { get; set; }

        public Champion()
        {
            Inventory = new Item[6];
            Stats = new ChampionStats(this);
            //Stats.AbilityPower = 0;
            //Stats.CooldownReduction = 0;
            Stats.Level = 1;
        }

        
    }
}