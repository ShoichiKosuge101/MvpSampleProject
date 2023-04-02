using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonClickEvent : MonoBehaviour
{
    public TMP_Text myText;
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
    public void ChangeText()
    {
        myText.SetText("Button Clicked!");
    }
}
