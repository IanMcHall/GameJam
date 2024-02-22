using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobManager : MonoBehaviour
{
    public GameObject SlottedHire;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GenerateJob();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            RetrieveHire();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SimulateJob(GenerateJob(), RetrieveHire());
        }
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

    public Job GenerateJob()
    {
        Job job = gameObject.AddComponent<Job>();


        job.XPGain = 14;
        job.StaminaMinimum = 1;
        job.TurnsToCompletion = 1;
        job.TotalBudget = Random.Range(1, 10);
        job.UpFrontPercentage = job.TotalBudget * job.TurnsToCompletion * .1f;
        job.Progress = 0;

        return job;
    }

    public Hire RetrieveHire()
    {
        try
        {
            if (SlottedHire != null)
            {
                var hire = SlottedHire.GetComponentInChildren<Hire>();

                if(hire != null)
                {
                    return hire;
                }
                else
                {
                    Debug.Log("Hire not found on card");

                    return null;
                }
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
}
