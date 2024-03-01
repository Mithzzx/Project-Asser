using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerRig : MonoBehaviour
{
    SavedShip savedShip;

    [SerializeField] CinemachineVirtualCamera virtualCamera;
    [SerializeField] GameObject[] ships;
    [SerializeField] Material[] materials;


    [System.Obsolete]
    private void Start()
    {
        savedShip = GameObject.Find("SavedShip").GetComponent<SavedShip>();

        ships[savedShip.selectedShip].gameObject.SetActive(true);
        ships[savedShip.selectedShip].GetComponent<MeshRenderer>().material = materials[savedShip.selectedMaterial];


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
