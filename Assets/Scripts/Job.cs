using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour
{
    public int Key { get; set; }
    public string ClientName { get; set; }
    public string ClientTitle { get; set; }
    public string Description { get; set; }
    public string FactionName { get; set; }
    public string FactionValue { get; set; }
    public int Rank { get; set; }
    public int Rarity { get; set; }
    public int XPGain { get; set; }
    public int StaminaMinimum { get; set; }
    public int TurnsToCompletion { get; set; }
    public int TotalBudget { get; set; }
    public int HitPoints { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    List<Keyword> ActionKeywords { get; set; }
    List<Keyword> LocationKeywords { get; set; }
    List<Keyword> TargetKeywords { get; set; }
    List<Keyword> RequiredKeywords { get; set; }
}
