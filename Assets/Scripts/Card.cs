using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    public Hire Hire;

    public TMP_Text nameText;
    public TMP_Text genderText;
    public TMP_Text ProfessionText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = Hire.Character.Name;
        genderText.text = Hire.Character.Gender;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
