using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoldyBuildhui.Models
{
    public class Item
    {        
        public string Name { get; set; }
        public string Plaintext { get; set; }
        public Image Image { get; set; }
        public ItemGold Gold { get; set; }
        public ItemStats Stats { get; set; }
        public Dictionary<string, bool> Maps { get; set; }
        public bool InStore { get; set; }
        public string RequiredChampion { get; set; }
        public List<string> Tags { get; set; }

        public Item()
        {
            InStore = true;
            RequiredChampion = null;
            Tags = new List<string>();
        }
        
        public class ItemGold
        {
            public int Base { get; set; }
            public int Total { get; set; }
            public int Sell { get; set; }
            public bool Purchasable { get; set; }
        }

        public class ItemStats
        {
            public double FlatHPPoolMod { get; set; }
            public double rFlatHPModPerLevel { get; set; }
            public double FlatMPPoolMod { get; set; }
            public double rFlatMPModPerLevel { get; set; }
            public double PercentHPPoolMod { get; set; }
            public double PercentMPPoolMod { get; set; }
            public double FlatHPRegenMod { get; set; }
            public double rFlatHPRegenModPerLevel { get; set; }
            public double PercentHPRegenMod { get; set; }
            public double FlatMPRegenMod { get; set; }
            public double rFlatMPRegenModPerLevel { get; set; }
            public double PercentMPRegenMod { get; set; }
            public double FlatArmorMod { get; set; }
            public double rFlatArmorModPerLevel { get; set; }
            public double PercentArmorMod { get; set; }
            public double rFlatArmorPenetrationMod { get; set; }
            public double rFlatArmorPenetrationModPerLevel { get; set; }
            public double rPercentArmorPenetrationMod { get; set; }
            public double rPercentArmorPenetrationModPerLevel { get; set; }
            public double FlatPhysicalDamageMod { get; set; }
            public double rFlatPhysicalDamageModPerLevel { get; set; }
            public double PercentPhysicalDamageMod { get; set; }
            public double FlatMagicDamageMod { get; set; }
            public double rFlatMagicDamageModPerLevel { get; set; }
            public double PercentMagicDamageMod { get; set; }
            public double FlatMovementSpeedMod { get; set; }
            public double rFlatMovementSpeedModPerLevel { get; set; }
            public double PercentMovementSpeedMod { get; set; }
            public double rPercentMovementSpeedModPerLevel { get; set; }
            public double FlatAttackSpeedMod { get; set; }
            public double PercentAttackSpeedMod { get; set; }
            public double rPercentAttackSpeedModPerLevel { get; set; }
            public double rFlatDodgeMod { get; set; }
            public double rFlatDodgeModPerLevel { get; set; }
            public double PercentDodgeMod { get; set; }
            public double FlatCritChanceMod { get; set; }
            public double rFlatCritChanceModPerLevel { get; set; }
            public double PercentCritChanceMod { get; set; }
            public double FlatCritDamageMod { get; set; }
            public double rFlatCritDamageModPerLevel { get; set; }
            public double PercentCritDamageMod { get; set; }
            public double FlatBlockMod { get; set; }
            public double PercentBlockMod { get; set; }
            public double FlatSpellBlockMod { get; set; }
            public double rFlatSpellBlockModPerLevel { get; set; }
            public double PercentSpellBlockMod { get; set; }
            public double FlatEXPBonus { get; set; }
            public double PercentEXPBonus { get; set; }
            public double rPercentCooldownMod { get; set; }
            public double rPercentCooldownModPerLevel { get; set; }
            public double rFlatTimeDeadMod { get; set; }
            public double rFlatTimeDeadModPerLevel { get; set; }
            public double rPercentTimeDeadMod { get; set; }
            public double rPercentTimeDeadModPerLevel { get; set; }
            public double rFlatGoldPer10Mod { get; set; }
            public double rFlatMagicPenetrationMod { get; set; }
            public double rFlatMagicPenetrationModPerLevel { get; set; }
            public double rPercentMagicPenetrationMod { get; set; }
            public double rPercentMagicPenetrationModPerLevel { get; set; }
            public double FlatEnergyRegenMod { get; set; }
            public double rFlatEnergyRegenModPerLevel { get; set; }
            public double FlatEnergyPoolMod { get; set; }
            public double rFlatEnergyModPerLevel { get; set; }
            public double PercentLifeStealMod { get; set; }
            public double PercentSpellVampMod { get; set; }
        }


    }

    
}