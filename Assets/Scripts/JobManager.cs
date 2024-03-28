using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class JobManager : MonoBehaviour
{
    public GameObject jobPrefab;
    public CardSlot CardSlot;
    public Hire hire;
    public List<Job> jobs;
    public Job CurrentJob;
    

    // Start is called before the first frame update
    void Start()
    {
        CardSlot = GetComponentInChildren<CardSlot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RetrieveHire();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
           var job = GenerateJob();

            Debug.Log(job.MainSkill.Name);

            SimulateJob(CurrentJob, hire);
        }
    }

    public void SimulateJob(Job job, Hire hire)
    {
        var result = PerformSkillCheck(hire, job);

        if (result == true)
        {
            Debug.Log("Completed!");
        } else { Debug.Log("Failed"); }

    }

    public Job GenerateJob()
    {
        GameObject jobObject = Instantiate(jobPrefab, transform);
        Job job = jobObject.AddComponent<Job>();
        

        job.XPGain = Random.Range(1,11);
        job.StaminaMinimum = Random.Range(1, 11); ;
        job.TurnsToCompletion = Random.Range(1, 11); ;
        job.TotalBudget = Random.Range(1, 11);
        job.UpFrontPercentage = job.TotalBudget * job.TurnsToCompletion * .1f;
        job.SelectMainSkill();
        
        jobs.Add(job);

        CurrentJob = job;
        
        return job;
    }

    public Hire RetrieveHire()
    {
        try
        {
            if (CardSlot.SlottedHire != null)
            {
                hire = CardSlot.SlottedHire;

                return hire;
            }
            else
            {
                Debug.Log("No card slotted");

                return null;
            }
            
        }
        catch (System.Exception)
        {
            Debug.Log("Hire could not be retrieved.");
            throw;
        }
    }

    //performs a skill check on the skill entered.
    public bool PerformSkillCheck(Hire hire, Job job)
    {
        int roll = RollDice();
        int total = 0;

        var skill = job.MainSkill;

        //takes the value of roll and adds it to the hire's stats to determine if passing
        switch (skill.Name.ToLower())
        {
            case "strength":
                total = roll + hire.Profession.STR;
                return total >= job.MainSkill.Value;

            case "dexterity":
                total = roll + hire.Profession.DEX;
                return total >= job.MainSkill.Value;

            case "intelligence":
                total = roll + hire.Profession.INT;
                return total >= job.MainSkill.Value;

            case "constitution":
                total = roll + hire.Profession.CON;
                return total >= job.MainSkill.Value;

            case "wisdom":
                total = roll + hire.Profession.WIS;
                return total >= job.MainSkill.Value;

            case "charisma":
                total = roll + hire.Profession.CHA;
                return total >= job.MainSkill.Value;

            default:
                Debug.Log($"Unknown skill: {skill}");
                return false;
        }
    }

    //Simulates a D20 roll
    private int RollDice()
    {
        return Random.Range(1, 11);
    }

    
}
