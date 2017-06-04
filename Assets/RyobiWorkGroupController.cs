using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RyobiWorkGroupController : MonoBehaviour {

    public Text text;
    public int clickFlag = 0;


    // Use this for initialization
    void Start () {
        DateTime thisDay = DateTime.Now;
        text.text = thisDay.ToString("G");
	}
	
	// Update is called once per frame
	void Update () {
        if (clickFlag == 0)
        {
            DateTime thisDay = DateTime.Now;
            text.text = thisDay.ToString("G");
        }
    }

    public void ButtonOnClick ()
    {
        if (clickFlag == 0)
        {
            clickFlag = 1;
        } else
        {
            clickFlag = 0;
        }
    }
}
