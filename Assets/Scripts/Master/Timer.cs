using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private static float deadTime;

    // Getting the singleton
    private UI myUI = UI.GetInstance();

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        /* When Player loses all lives, bool timer changes to true in Playermanager Class.
           Resets the timer and saves total time to deadTime.
           Bool changes back to false in PLayerManager Class. */
        if (PlayerManager.timer == true)
        {
            float time = Time.time - startTime;

            string minutes = ((int)time / 60).ToString();
            string seconds = (time % 60).ToString("f1");

            myUI.UpdateTime(timerText, minutes, seconds);
            deadTime = Time.time;
            PlayerManager.timer = false;
        }
        // Counts time and subtracts deadTime correcting time if Player has lost all lives at some point.
        else
        {
            float time = Time.time - deadTime;

            string minutes = ((int)time / 60).ToString();
            string seconds = (time % 60).ToString("f1");

            myUI.UpdateTime(timerText, minutes, seconds);
        }
    }
}
