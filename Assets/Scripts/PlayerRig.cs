using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRig : MonoBehaviour
{
    [SerializeField] GameObject[] ships;
    [SerializeField] GameObject crashMesh;

    PlayerShip ps;

    private void Start()
    {
        ps = GameObject.Find("SavedShip").GetComponent<PlayerShip>();
        GameObject.Find(ps.selectedShip.name).gameObject.SetActive(true);
        crashMesh = ps.crashMesh;
    }
}
