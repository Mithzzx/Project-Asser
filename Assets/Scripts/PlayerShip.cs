using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    Garagepannel gp;
    public GameObject selectedShip;
    public GameObject crashMesh;
    public Material selectedMaterial;



    private void Awake()
    {
        int numMusicPlayer = FindObjectsOfType<PlayerShip>().Length;
        if (numMusicPlayer > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

    public void UpdateShip(GameObject ss ,GameObject cm ,Material material)
    {
        selectedShip = ss;
        crashMesh = cm;
        selectedMaterial = material;
    }
}