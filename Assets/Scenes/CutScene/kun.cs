using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kun : MonoBehaviour
{
    [SerializeField] GameObject kunkun;
    [SerializeField] Vector3 pos;
    [SerializeField] float time;

    private void Start()
    {
        Invoke("RO", time);
    }

    private void RO()
    {
        Instantiate(kunkun, pos, Quaternion.identity);
    }
}