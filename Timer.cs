using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text TimeText;
    private float TimeEiEi ;
    public UpSideDown _UpSideDown;

    private void FixedUpdate()
    {
        TimeEiEi = _UpSideDown.currentTime;
        
    }

    
    void Update()
    {
        TimeText.text = TimeEiEi.ToString("0");
    }

}
