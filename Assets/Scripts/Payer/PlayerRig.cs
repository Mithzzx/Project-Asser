using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerRig : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    [SerializeField] GameObject[] ships;
    [SerializeField] Material[] materials;

    [System.Obsolete]
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

    public void LoadShip()
    {
        ShipData data = SaveSystem.LoadShip();

        int shipNumber = data.shipNumber;
        int materialNumber = data.materialNumber;

        ships[shipNumber].gameObject.SetActive(true);
        ships[shipNumber].GetComponent<MeshRenderer>().material = materials[materialNumber];
    }
}
