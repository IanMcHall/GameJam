using DefaultNamespace;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class SkillCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //performs a skill check on the skill entered.
    public bool PerformSkillCheck(Hire hire, Job job, string skill)
    {
        int roll = RollDice();
        int total = 0;

        //takes the value of roll and adds it to the hire's stats to determine if passing
        switch (skill.ToLower())
        {
            case "strength":
                total = roll + hire.Profession.Strength;
                return total >= job.StrengthRequirement;

            case "dexterity":
                total = roll + hire.Profession.Dexterity;
                return total >= job.DexterityRequirement;

            case "intelligence":
                total = roll + hire.Profession.Intelligence;
                return total >= job.IntelligenceRequirement;

            case "constitution":
                total = roll + hire.Profession.Constitution;
                return total >= job.ConstitutionRequirement;

            case "wisdom":
                total = roll + hire.Profession.Wisdom;
                return total >= job.WisdomRequirement;

            case "charisma":
                total = roll + hire.Profession.Charisma;
                return total >= job.CharismaRequirement;

            default:
                Debug.Log($"Unknown skill: {skill}");
                return false;
        }
    }

    //Simulates a D20 roll
    private int RollDice()
    {
        return Random.Range(1, 21);
    }
}
