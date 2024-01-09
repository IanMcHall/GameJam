using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jobs : MonoBehaviour
{
    public int JobKey { get; set; }
    public string ClientName { get; set; }
    public string ClientTitle { get; set; }
    public string JobDescription { get; set; }
    public string FactionName { get; set; }
    public string FactionValue { get; set; }
    public int JobRank { get; set; }
    public int JobRarity { get; set; }
    public int XPGain { get; set; }
    public int StaminaMinimum { get; set; }
    public int TurnsToCompletion { get; set; }
    public int TotalBudget { get; set; }
    public int JobHP { get; set; }
    public int STR { get; set; }
    public int INT { get; set; }
    public int DEX { get; set; }
    public int CON { get; set; }
    public int WIS { get; set; }
    public int CHA { get; set; }

    List<Keywords> ActionKeywords { get; set; }
    List<Keywords> LocationKeywords { get; set; }
    List<Keywords> TargetKeywords { get; set; }
    List<Keywords> RequiredKeywords { get; set; }

}
