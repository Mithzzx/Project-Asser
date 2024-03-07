using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class fps : MonoBehaviour
{
    [SerializeField] TMP_Text fpsText;
    [SerializeField] LimitFPS fp;

    private void Start()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        fpsText.text = "FPS : " + LimitFPS.fps.ToString();
    }
}
