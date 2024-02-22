using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public JobManager JobManager;

    public GameObject Visuals;

    // Start is called before the first frame update
    void Start()
    {
        JobManager = FindAnyObjectByType<JobManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
            var material = Visuals.GetComponent<MeshRenderer>().material;

        if (JobManager.SlottedHire != null)
        {
            if (Input.GetMouseButton(0))
            {

                material.color = Color.grey;

                //function to run
                JobManager.SimulateJob(JobManager.GenerateJob(), JobManager.RetrieveHire());
            }
            else
            {
                material.color = Color.white;
            }
        }

       
    }


}
