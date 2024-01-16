using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sidebar : MonoBehaviour
{
    public static bool IsPaused;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if its the title screen then doesn't allow the pause to be used
        if (SceneManager.GetActiveScene().name != "TitleScreen")
        {
            if (Input.GetButtonDown("Cancel"))
            {
                TogglePause();
            }
        }

    }

    public void TogglePause()
    {
        //toggles pause variable
        IsPaused = !IsPaused;

        if (IsPaused)
        {
            //insert soundFX here

            Time.timeScale = 0f;

            Debug.Log("Game Paused");

            animator.SetBool("IsPaused", true);
        }
        else
        {
            //insert soundFX here


            Time.timeScale = 1f;

            Debug.Log("Game Resumed");

            animator.SetBool("IsPaused", false);
        }
    }
}
