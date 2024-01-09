using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hires : MonoBehaviour
{

    public int HireKey {  get; set; }
    public string HireName { get; set; }
    public string ProfessionName { get; set; }
    public string ProfessionDescription { get; set; }
    public string FactionName { get; set; }
    public string FactionValue {  get; set; }
    public int HireRank { get; set; }
    public int HireRarity { get; set; }
    public int XP { get; set; }
    public int ActionStat { get; set; }
    public int Stamina { get; set; }
    public int JobsCompleted { get; set; }
    public int JobsFailed { get; set;}
    public int BudgetRequirement { get; set;}
    public float BudgetModifier { get; set; }
    public int Retirement { get; set; }
    public int HireHP { get; set; }
    public int STR {  get; set; }
    public int INT { get; set; }
    public int DEX { get; set; }
    public int CON { get; set; }
    public int WIS { get; set; }
    public int CHA { get; set; }
    public int EV_STR {  get; set; }
    public int EV_INT { get; set;}
    public int EV_DEX { get; set; }
    public int EV_CON { get; set; }
    public int EV_WIS { get;set; }
    public int EV_CHA { get; set; }
    public List<HirePerks> HirePerks { get; set; }

}
