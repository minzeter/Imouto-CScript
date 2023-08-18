using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountdown : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 10f;

    [SerializeField] private Text countdown;
    
    public GameObject Main;
    public GameObject Sleep;
    public GameObject TextCount;
    public int ScoreCount;
    public bool StateCh;
    public bool MainCh;


    void Start()
    {
        ScoreCount = 0;
        Main.SetActive(true);
        StateCh = true;
        currentTime = startingTime;
    }

    private void FixedUpdate()
    {
        SleepActive();
        MainActive();
        /*print("State:" +StateCh);
        print("Main" + MainCh);
        print("Score" +ScoreCount);*/
    }

    void Update()
    {

        currentTime -= 1 * Time.deltaTime;
        countdown.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            StateCh = false;
            TextCount.SetActive(false);
        }
    }

    public void Score(int amount)
    {
        ScoreCount += amount;
        if (ScoreCount >= 1)
        {
            MainCh = true;
        }
    }
    
    public void MainActive()
    {
        if (StateCh == false && MainCh == true)
        {
            Main.SetActive(true);
            Sleep.SetActive(false);

            //_UpSideDown.potion.SetActive(false);
        }

    }

    public void SleepActive()
    {
        if (StateCh == false)
            
        {
            Sleep.SetActive(true);
            Main.SetActive(false);
            //_UpSideDown.potion.SetActive(true);
        }


    }
}
