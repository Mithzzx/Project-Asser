using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField] float timetodestroy = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timetodestroy);
    }

}
