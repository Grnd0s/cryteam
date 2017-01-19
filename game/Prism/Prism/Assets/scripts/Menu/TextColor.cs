using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        theText = firstColor;
    }

    public void changeColorToLast()
    {

    }
    public void changeColorToFirst()
    {
        GUI.color = firstColor;
    }

    public static implicit operator TextColor(Color v)
    {
        throw new NotImplementedException();
    }
}
