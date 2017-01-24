using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour {



    public TextColor ltext;
    bool isClick = false;
	// Use this for initialization
	void Start ()
    {
        goExit();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void goEnter()
    {
        ltext.changeColorToLast();
    }
    public void goExit()
    {
        ltext.changeColorToFirst();
    }
}
