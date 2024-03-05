using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    [SerializeField]float startTime = 10f;

    int min;
    float sec;

    [SerializeField] TMP_Text timerText;
    void Start()
    {
        currentTime = startTime;
    }


    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        min = (int)(currentTime / 60);
        sec = currentTime - min * 60;
        timerText.text = "0"+min.ToString()+ ":" +sec.ToString("0.00");
    }
}
