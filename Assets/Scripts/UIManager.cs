using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Animator DBoxAnimator;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ToggleDialogueBox()
    {
        if (DBoxAnimator.GetBool("IsShowing") == false)
        {
            DBoxAnimator.SetBool("IsShowing", true);
        }
        else
        {
            DBoxAnimator.SetBool("IsShowing", false);
        }
    }
}
