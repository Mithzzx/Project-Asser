using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    [SerializeField] float increaseTime = 10f;
    [SerializeField] Timer timer;
    int inc = 0;

    [SerializeField] Material activeMaterial;
    [SerializeField] Material touchedMaterial;
    bool isactive;
    [SerializeField] public bool isTouched;

    Rings rings;

    private void Start()
    {
        rings = GetComponentInParent<Rings>();
    }


    public void Activate()
    {
        isactive = true;
        gameObject.GetComponent<MeshRenderer>().material = activeMaterial;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isactive)
        {
            gameObject.GetComponent<MeshRenderer>().material = touchedMaterial;
            isTouched = true;

            if (inc==0)
            {
                timer.IncreaeTime(increaseTime);
                inc++;
                Debug.Log("Added  :" + increaseTime);
            }
        }
    }
}
