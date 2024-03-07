using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rings : MonoBehaviour
{
    [SerializeField] public int activeRing = 0;
    [SerializeField] int noOfRings;

    [SerializeField] GameObject[] rings;

    private void Start()
    {
        foreach (GameObject ring in rings)
        {
            ring.SetActive(false);
        }
        int i = 0;
        while (i < noOfRings)
        {
            rings[i].SetActive(true);
            i++;
        }

        rings[activeRing].GetComponent<Ring>().Activate();
    }

    private void Update()
    {
        if (rings[activeRing].GetComponent<Ring>().isTouched)
        {
            activeRing += 1;
            rings[activeRing].GetComponent<Ring>().Activate();

            rings[(activeRing-1) + noOfRings].SetActive(true);

        }
    }

}
