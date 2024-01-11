using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Hire hire;

    // Start is called before the first frame update
    void Start()
    {
        hire = new Hire()
        {
            name = "Test"
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
