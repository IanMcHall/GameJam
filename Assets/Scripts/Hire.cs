using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Hire : MonoBehaviour
{

    // "Key": Future-proofing under the assumption we'll create a database to store generated hires in; can/should be commented out for now
    // public int Key {  get; set; }

    // "Character": Stores names/titles/descriptions/portraits
    public Character Character;
    // "Profession": Stores profession information
    public Profession Profession { get; set; }
    // "Rank": Substitute for a numeric level system
    public int Rank { get; set; }
    // "XPCurrent/XPToLevel": How much XP the hire currently has and how much until they reach their next Rank Up
    public int XPCurrent { get; set; }
    public int XPToLevel { get; set; }
    // "JobsCompleted/JobsFailed": Tracks the amount of work the Hire has done
    public int JobsCompleted { get; set; }
    public int JobsFailed { get; set;}
    // "Retirement": How close the Hire is from removing themselves from the hiring pool. This can go both up and down, and on a variety of factors (success, failure, displeasure, etc).
    // If a character's HP reaches 0 on a Job they are auto-retired, IE: killed
    public float Retirement { get; set; }

    // "BudgetRequirement": The base amount of salary a Hire expects to be paid before getting sent out on a job
    public int BudgetRequirement { get; set;}
    // "BudgetModifier": A modifier to the BudgetRequirement amount based off of a combination of Rank, Rarity and Retirement, making the hire's asking price go up or down as they grow
    public float BudgetModifier { get; set; }

    // EVs, or "Effort Values". "EV" stats are growth modifiers:
    // * When a Hire goes up in Rank they gain x-amount of additional points to their stats. 
    // * Which stat the points go to are determined by their EV stats
    // * EV stats are gained by doing jobs, and correlate to the type of job done
    // * As an example: Killing a swarm of bats would give DEX and STR EVs, while performing in a marching band would give CHA and CON EVs
    // * The more jobs a Hire does that contain a specific EV, the more likely they are to gain that stat upon gaining Rank
    public int EV_STR {  get; set; }
    public int EV_INT { get; set;}
    public int EV_DEX { get; set; }
    public int EV_CON { get; set; }
    public int EV_WIS { get;set; }
    public int EV_CHA { get; set; }
    
    // Does a hire have perks or does a player have perks?
    // ^^ Both; that said I should change terminology to separate the two, so Hires have Perks and players have.... (am open to suggestions lol)
    public List<HirePerk> Perks { get; set; }
}
