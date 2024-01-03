using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    Garagepannel gp;
    public GameObject selectedShip;
    public GameObject crashMesh;
    public Material selectedMaterial;


    public void UpdateShip(GameObject ss ,GameObject cm ,Material material)
    {
        selectedShip = ss;
        crashMesh = cm;
        selectedMaterial = material;
    }
}