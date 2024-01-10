using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        IsPaused = !IsPaused;

        if (IsPaused)
        {
            Time.timeScale = 0f;

            Debug.Log("Game Paused");

            animator.SetBool("IsPaused", false);
        }
        else
        {
            Time.timeScale = 1f;

            Debug.Log("Game Resumed");

            animator.SetBool("IsPaused", true);
        }
    }
}
