using UnityEngine;

namespace DefaultNamespace
{
    public class Profession : MonoBehaviour
    {
        public string Name;
        public string Description;

        // "Rarity": How likely the Profession is to be generated; higher rarity means less chance of being generated
        public int Rarity;

        // "ActionStat": The default stat a character uses to roll with
        // EX: A Soldier's primary action stat would be STR, a Mage would use INT, etc. etc.
        // The Job may either define what stat the Hire must roll with, or otherwise allow the Hire to roll with their primary action stat instead.
        public int ActionStat;

        // "Stamina": Stamina is defined by a combination of the BaseStamina stat found in a Profession and any Perks the Hire has
        // Stamina is used by Hires on Jobs, and Hires must have a minimum amount of Stamina before being available to use in the Job Pool
        // If the Hire's stamina reaches 0 while on a job their work is considered a failure
        // Stamina has a chance of being regained every x-turns by rolling the Hire's main ActionStat vs ... something idk I'll figure that out later
        public int Stamina;

        // "HitPoints": If this reaches 0 on a mission, the Hire is auto-retired
        // HP fully resets after a job is completed and a Hire has regained at least 1 Stamina point
        // HP is calculated as a value based off of Constitution and Rank, modified by perks; I haven't fully worked out the math here yet either
        public int HitPoints;

        // Your usual assortment of character stats; nothing too surprising here
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Constitution;
        public int Wisdom;
        public int Charisma;
    }
}