using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Hire : MonoBehaviour
{
    // What is a Hire Key? Is it an Id?
    public int Key {  get; set; }
    // Should we break this into a separate class with FirstName/LastName/Title?
    public string Name { get; set; }
    public Profession Profession { get; set; }
    public Faction Faction { get; set; }
    public int Rank { get; set; }
    public int Rarity { get; set; }
    public int XP { get; set; }
    // What is this?
    public int ActionStat { get; set; }
    public int Stamina { get; set; }
    public int JobsCompleted { get; set; }
    public int JobsFailed { get; set;}
    
    // What is this?
    public int BudgetRequirement { get; set;}
    public float BudgetModifier { get; set; }
    
    // Should this be a floating point value?
    public int Retirement { get; set; }
    // What is this?
    public int HireHP { get; set; }
    public int Strength {  get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    
    // What are these?
    public int EV_STR {  get; set; }
    public int EV_INT { get; set;}
    public int EV_DEX { get; set; }
    public int EV_CON { get; set; }
    public int EV_WIS { get;set; }
    public int EV_CHA { get; set; }
    
    // Does a hire have perks or does a player have perks?
    public List<HirePerk> Perks { get; set; }
}
