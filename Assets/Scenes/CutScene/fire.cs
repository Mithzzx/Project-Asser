using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    [SerializeField] ParticleSystem Fire;
    [SerializeField] Vector3 pos;
    [SerializeField] float time;

    private void Start()
    {
        Invoke("RO", time);
    }

    private void RO()
    {
        Instantiate(Fire, pos, Quaternion.identity);
    }
}
