using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool SimulateJob(Job job, Hire hire)
    {

        //Checks if Hires stats meet the requirements of the job
       if (hire.Profession.Strength >= job.StrengthRequirement &&
            hire.Profession.Intelligence >= job.IntelligenceRequirement &&
            hire.Profession.Dexterity >= job.DexterityRequirement &&
            hire.Profession.Constitution >= job.ConstitutionRequirement &&
            hire.Profession.Wisdom >= job.WisdomRequirement &&
            hire.Profession.Charisma >= job.CharismaRequirement)
        {
            Debug.Log("Hire meets job requirements!");

            return true;
        }
        else
        {
            Debug.Log("Hire does not meet job requirements");

            return false;
        }
    }

    public void GenerateJob()
    {
        Job job = gameObject.AddComponent<Job>();


        job.XPGain = 14;
        job.StaminaMinimum = 1;
        job.TurnsToCompletion = 1;
        job.TotalBudget = Random.Range(1, 10);
        job.UpFrontPercentage = job.TotalBudget * job.TurnsToCompletion * .1f;
        job.Progress = 0;

        
    }
}