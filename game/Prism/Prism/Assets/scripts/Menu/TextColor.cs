using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColor : MonoBehaviour {
    

    public Color firstColor;
    public Color lastColor;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
    }

    public void changeColorToLast()
    {
        GetComponent<Text>().color = lastColor;
    }
    public void changeColorToFirst()
    {
        GetComponent<Text>().color = firstColor;
    }
    
}
