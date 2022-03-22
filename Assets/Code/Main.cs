using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//pendiente revisar esta guia https://forum.unity.com/threads/converting-seconds-to-hours-minutes-seconds-for-count-down-timer.861388/

public class Main : MonoBehaviour
{

    bool play = false;
    float currentTime = 8598;
    float liveTime = 0;
    int minutes = 0;
    int seconds = 0;
    int hour = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            //minutes = Mathf.FloorToInt((Time.time - currentTime)/60f);
            //seconds = Mathf.FloorToInt((Time.time - currentTime) - minutes * 60f);
            //hour = Mathf.FloorToInt((Time.time - currentTime)/ 3600f);

            seconds = Mathf.FloorToInt((currentTime + Time.time) % 60f);
            minutes = Mathf.FloorToInt((currentTime+ Time.time) / 60f);
            hour = Mathf.FloorToInt((currentTime+ Time.time) / 3600f);


            Debug.Log(string.Format("{0:0}:{1:00}:{2:00}", hour, minutes, seconds));
            //Debug.Log(Time.time- currentTime);
        }
        
    }

    public void playTime() {
       // currentTime = Time.time;
        if (play)
        {
            play = false;
        }
        else {
            play = true;
        }
    }
}
