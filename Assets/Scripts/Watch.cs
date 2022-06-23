using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Watch : MonoBehaviour {
    private Text textClock;
    private DateTime startTime;
    private DateTime time;
    public bool frameScenario = false;

    void Awake (){
        textClock = GetComponent<Text>();
        startTime = DateTime.Now;
        time = new DateTime(2022, 4, 1, 7, 54, 25);
    }

    void Update (){
        DateTime timeToDisplay;
        
        if (frameScenario)
        {
            TimeSpan span = (DateTime.Now - startTime);
            timeToDisplay = time.Add(span);
        }
        else 
        {
            timeToDisplay = DateTime.Now;
        }
        
        string hour = LeadingZero( timeToDisplay.Hour );
        string minute = LeadingZero( timeToDisplay.Minute );
        string second = LeadingZero( timeToDisplay.Second );
        textClock.text = hour + ":" + minute + ":" + second;
      }
    
    string LeadingZero (int n){
        return n.ToString().PadLeft(2, '0');
    }
}
