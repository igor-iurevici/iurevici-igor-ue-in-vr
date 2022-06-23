using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text timerText;
    float remainingTime = 300;

    // Start is called before the first frame update
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            float minutes = Mathf.FloorToInt(remainingTime / 60);
            float seconds = Mathf.FloorToInt(remainingTime % 60);

            if (seconds < 10) {
                timerText.text = "0" + minutes + " : " + "0" + seconds;
            }
            else
            {
                timerText.text = "0" + minutes + " : " + seconds;
            }

        }
        else
        {
            timerText.text = "00 : 00";
        }
    }
}
