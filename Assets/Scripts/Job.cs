using DefaultNamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour
{
    // public int Key { get; set; }
    
    // "Rank": How tough the job is; the various requirements/stats/rewards from a job should increase with it's rank
    public int Rank { get; set; }
    // "Rarity": How likely the job is to appear in the general pool - may actually not need this so commenting out for the moment
    // public int Rarity { get; set; }
    
    // "XPGain": How much XP the Hires on the job will gain for completing the task; this should probably be modified to increase/decrease based on how well the job went
    public int XPGain { get; set; }
    // "StaminaMinimum": The bare minimum Stamina that the job will remove from each Hire. If the Hires do a poor job, this amount should increase
    public int StaminaMinimum { get; set; }
    // "TurnsToCompletion": How many in-game turns it will take before the job is completed and the player sees the results/recieves rewards/etc
    public int TurnsToCompletion { get; set; }
    // "TotalBudget": The maximum amount of cash the client is offering for the job. 
    public int TotalBudget { get; set; }
    // "UpFrontPercentage": A percentage of the budget the player will receive when initially filling the job request
    public int UpFrontPercentage { get; set; }
    // "Progress": A number that must be reduced to 0 via player rolls to complete the request; base value is defined by the job and then modified by Rank
    public int Progress { get; set; }
    // "RollsTaken": This is how many rolls it's taken the Hire to complete the task; this is always a minimum of 1 and increments each time the Hire rolls without setting Progress to 0
    public int RollsTaken { get; set; }
    // Stats: When the Hire attempts to complete a job request they roll their needed stat value against the Job's stat value as a pass/fail check
    // They then roll x-d(y) (x = number they beat their check roll by, y = their stat value) and remove that value from the Progress value
    // Example: Bob the Bowman has been hired to kill a bear. Bob uses Dexterity to attack, and the Bear uses Strength to defend.
    // Each rolls a D12 and adds the results to their relevant stat; Bob rolls a 9 and adds that to his 5 Dex, while the Bear rolls a 7 and adds that to its 3 strength. Bob has a total of 14, the Bear has a total of 10.
    // Bob then rolls x-d(y), x = the number of points Bob beat the Bear's roll by, and y = Bob's Dexterity stat (or, 4d5). We then remove (4d5 + (Progress/5)) from the Progress value.
    // If Progress == 0, job done; if not, roll again
    // If Bob did NOT pass the initial check against the Bear, then the bear does damage to the Hire's HP for (1+Rank-d(Strength*Rank))
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
