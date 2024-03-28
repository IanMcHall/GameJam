using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill 
{
    public string Name;
    public string Description;
    public int Value;

    private void Awake()
    {
        Value = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        Value = Random.Range(0, 11);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
