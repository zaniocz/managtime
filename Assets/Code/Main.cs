using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//pendiente revisar esta guia https://forum.unity.com/threads/converting-seconds-to-hours-minutes-seconds-for-count-down-timer.861388/

public class Main : MonoBehaviour
{

    bool play = false;
    float currentTime = 0;
    float liveTime = 0;
    int minutes = 0;
    int seconds = 0;
    int hour = 0;

    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            //text.text = string.Format("{0:0}:{1:00}:{2:00}", TimeSpan.FromSeconds(currentTime + Time.time).Hours, TimeSpan.FromSeconds(currentTime + Time.time).Minutes, TimeSpan.FromSeconds(currentTime + Time.time).Seconds);
            text.text = string.Format("{0:0}:{1:00}:{2:00}", TimeSpan.FromSeconds(Time.time - currentTime).Hours, TimeSpan.FromSeconds(Time.time - currentTime).Minutes, TimeSpan.FromSeconds(Time.time - currentTime).Seconds);
            //Debug.Log(string.Format("{0:0}:{1:00}:{2:00}", TimeSpan.FromSeconds(currentTime + Time.time).Hours, TimeSpan.FromSeconds(currentTime + Time.time).Minutes, TimeSpan.FromSeconds(currentTime + Time.time).Seconds));
            seconds = Mathf.FloorToInt((currentTime + Time.time) % 60f);
            minutes = Mathf.FloorToInt((currentTime+ Time.time) / 60f);
            hour = Mathf.FloorToInt((currentTime+ Time.time) / 3600f);
        }
        
    }

    public void playTime() {
        currentTime = Time.time;
        if (play)
        {
            play = false;
        }
        else {
            play = true;
        }
    }
}
