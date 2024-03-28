using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JobUIManager : MonoBehaviour
{

    public Job job;

    public JobManager jobManager;

    public TMP_Text MainSkillText;
    public TMP_Text SkillValueText;

    
    void Start()
    {
            jobManager = GetComponentInChildren<JobManager>();
    }

    // Update is called once per frame
    void Update()
    {

        updateJob();
    }

    public void updateJob()
    {
        job = jobManager.CurrentJob;
        
        if (job != null)
        {
            MainSkillText.text = job.MainSkill.Name;
            SkillValueText.text = job.MainSkill.Value.ToString();
        }
    }
}
