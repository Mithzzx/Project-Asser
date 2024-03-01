using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitFPS : MonoBehaviour
{
    [SerializeField] public static int fps = 60;

    public void Setfps(int toset)
    {
        fps = toset;
        Application.targetFrameRate = fps;
    }

    void Start()
    {
        Application.targetFrameRate = fps;
    }

}
