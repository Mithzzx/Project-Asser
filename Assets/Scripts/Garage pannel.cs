using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garagepannel : MonoBehaviour
{
    public int shipNumber;
    public int materialNumber;

    [SerializeField] public GameObject selectedShip;
    public GameObject crashmesh;
    public Material selectedMaterial;

    PlayerShip ps;

    private void Start()
    {
        ps = GameObject.Find("SavedShip").GetComponent<PlayerShip>();
        selectedMaterial = selectedShip.GetComponent<MeshRenderer>().material;
    }
    public void UpdateShip(GameObject activeShip)
    {
        selectedShip.gameObject.SetActive(false);
        selectedShip = activeShip;
        selectedShip.gameObject.SetActive(true);
    }

    public void Updatecr(GameObject cr)
    {
        crashmesh = cr;
    }
    public void UpdateMaterial(Material material)
    {
        selectedMaterial = material;
        selectedShip.GetComponent<MeshRenderer>().material = selectedMaterial;
    }

    public void UpdateLazer()
    {
        return;
    }

    public void SaveChanges()
    {
        ps.UpdateShip(selectedShip,crashmesh,selectedMaterial);
    }

    public void SetShipNumber(int number)
    {
        shipNumber = number;
    }
    public void SetMaterialNumber(int number)
    {
        materialNumber = number;
    }
}
