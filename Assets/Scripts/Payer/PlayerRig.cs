using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerRig : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    [SerializeField] GameObject[] ships;
    [SerializeField] Material[] materials;


    private void Start()
    {
        foreach (GameObject ship in ships)
        {
            if (ship.active == true)
            {
                virtualCamera.LookAt = ship.transform;
                virtualCamera.Follow = ship.transform;

            }
        }
    }
}
