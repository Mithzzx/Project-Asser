using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitFPS : MonoBehaviour
{
    [Serializefield] int fps = 60;
    void Start()
    {
        Application.targetFrameRate = fps;
    }

}
