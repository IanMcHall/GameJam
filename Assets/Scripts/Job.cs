using DefaultNamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour
{
    // public int Key { get; set; }

    // "Rank": How tough the job is; the various requirements/stats/rewards from a job should increase with it's rank
    public int Rank;
    // "Rarity": How likely the job is to appear in the general pool - may actually not need this so commenting out for the moment
    // public int Rarity { get; set; }

    // "XPGain": How much XP the Hires on the job will gain for completing the task; this should probably be modified to increase/decrease based on how well the job went
    public int XPGain;
    // "StaminaMinimum": The bare minimum Stamina that the job will remove from each Hire. If the Hires do a poor job, this amount should increase
    public int StaminaMinimum;
    // "TurnsToCompletion": How many in-game turns it will take before the job is completed and the player sees the results/recieves rewards/etc
    public int TurnsToCompletion;
    // "TotalBudget": The maximum amount of cash the client is offering for the job. 
    public int TotalBudget;
    // "UpFrontPercentage": A percentage of the budget the player will receive when initially filling the job request
    public float UpFrontPercentage;
    // "Progress": A number that must be reduced to 0 via player rolls to complete the request; base value is defined by the job and then modified by Rank
    public int Progress;
    // "RollsTaken": This is how many rolls it's taken the Hire to complete the task; this is always a minimum of 1 and increments each time the Hire rolls without setting Progress to 0
    public int RollsTaken;
    // Stats: When the Hire attempts to complete a job request they roll their needed stat value against the Job's stat value as a pass/fail check
    // They then roll x-d(y) (x = number they beat their check roll by, y = their stat value) and remove that value from the Progress value
    // Example: Bob the Bowman has been hired to kill a bear. Bob uses Dexterity to attack, and the Bear uses Strength to defend.
    // Each rolls a D12 and adds the results to their relevant stat; Bob rolls a 9 and adds that to his 5 Dex, while the Bear rolls a 7 and adds that to its 3 strength. Bob has a total of 14, the Bear has a total of 10.
    // Bob then rolls x-d(y), x = the number of points Bob beat the Bear's roll by, and y = Bob's Dexterity stat (or, 4d5). We then remove (4d5 + (Progress/5)) from the Progress value.
    // If Progress == 0, job done; if not, roll again
    // If Bob did NOT pass the initial check against the Bear, then the bear does damage to the Hire's HP for (1+Rank-d(Strength*Rank))

    public Skill MainSkill;

    List<Keyword> ActionKeywords;
    List<Keyword> LocationKeywords;
    List<Keyword> TargetKeywords;
    List<Keyword> RequiredKeywords;
    List<Skill> Skills;

    private void Awake()
    {
        Skills = new List<Skill>();

        Skills.Add(new Skill { Name = "Strength", Description = "Represents the physical power and muscular capabilities of a character, enabling them to perform feats requiring brute force, endurance, and raw might." });
        Skills.Add(new Skill { Name = "Intelligence", Description = "Reflects a character's cognitive abilities, such as reasoning, memory, problem-solving, and learning capacity, allowing them to navigate complex situations and understand intricate concepts with greater ease." });
        Skills.Add(new Skill { Name = "Dexterity", Description = "Denotes a character's agility, finesse, and quickness, determining their skill in performing delicate tasks, hand-eye coordination, and swift movements during combat or stealth situations." });
        Skills.Add(new Skill { Name = "Constitution", Description = "Encompasses a character's physical resilience, vitality, and endurance, determining their ability to withstand injuries, fatigue, and environmental hazards while maintaining overall health and stamina." });
        Skills.Add(new Skill { Name = "Wisdom", Description = "Signifies a character's intuition, perception, and understanding of their surroundings, enabling them to make wise decisions, perceive hidden details, and interact with nature or divine forces." });
        Skills.Add(new Skill { Name = "Charisma", Description = "Represents a character's personal magnetism, persuasiveness, and ability to influence others, allowing them to lead effectively, negotiate favorable outcomes, and manipulate social situations." });
    }

    public Skill SelectMainSkill()
    {
        MainSkill = Skills[(Random.Range(0, 6))];
        MainSkill.Value = Random.Range(1, 11);

        return MainSkill;
    }

}
