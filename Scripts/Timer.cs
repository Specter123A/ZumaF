using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float currentTime;
    public float startTime =20f;

    [SerializeField]
    TMP_Text countDown;

// Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;   //start with 20 secs
    }

    // Update is called once per frame
    void Update()
    {
        currentTime-= 1* Time.deltaTime;     //count each second
        countDown.text = currentTime.ToString("0");

        if(currentTime <=0)
        {
            currentTime=0;
        }
    }
}
