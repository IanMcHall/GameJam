using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class Profession : MonoBehaviour
    {
        public CSVProfessionImporter ProfessionGenerator;

        public string Name;
        public string Description;
        public int Group;

        // "Rarity": How likely the Profession is to be generated; higher rarity means less chance of being generated
        public int HireRarity;

        // "ActionStat": The default stat a character uses to roll with
        // EX: A Soldier's primary action stat would be STR, a Mage would use INT, etc. etc.
        // The Job may either define what stat the Hire must roll with, or otherwise allow the Hire to roll with their primary action stat instead.
        public string ActionStat;

        // "Stamina": Stamina is defined by a combination of the BaseStamina stat found in a Profession and any Perks the Hire has
        // Stamina is used by Hires on Jobs, and Hires must have a minimum amount of Stamina before being available to use in the Job Pool
        // If the Hire's stamina reaches 0 while on a job their work is considered a failure
        // Stamina has a chance of being regained every x-turns by rolling the Hire's main ActionStat vs ... something idk I'll figure that out later
        public int BaseStamina;

        // "HitPoints": If this reaches 0 on a mission, the Hire is auto-retired
        // HP fully resets after a job is completed and a Hire has regained at least 1 Stamina point
        // HP is calculated as a value based off of Constitution and Rank, modified by perks; I haven't fully worked out the math here yet either
        public int BaseHP;

        // Your usual assortment of character stats; nothing too surprising here
        public int STR;
        public int INT;
        public int DEX;
        public int CON;
        public int WIS;
        public int CHA;
        public List<int> PerkGroupIDs;

        private void Awake()
        {
            InitializeProfession();
        }

        private void InitializeProfession()
        {

            if (ProfessionGenerator == null )
            {
                var Profession = ProfessionGenerator.GetRandomProfession();

                Name = Profession.Name;
                Description = Profession.Description;
                Group = Profession.Group;
                HireRarity = Profession.HireRarity;
                ActionStat = Profession.ActionStat;
                BaseStamina = Profession.BaseStamina;
                BaseHP = Profession.BaseHP;
                STR = Profession.STR;
                INT = Profession.INT;
                DEX = Profession.DEX;
                WIS = Profession.WIS;
                CON = Profession.CON;
                CHA = Profession.CHA;
                PerkGroupIDs = Profession.PerkGroupIDs;

                printStats();
            }
        }

        void printStats()
        {
            Debug.Log(Name + ": " + Description);
            Debug.Log(STR);
            Debug.Log(INT);
            Debug.Log(DEX);
            Debug.Log(WIS);
            Debug.Log(CON);
            Debug.Log(CHA);

        }
    }
}