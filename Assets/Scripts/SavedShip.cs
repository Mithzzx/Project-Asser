using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedShip : MonoBehaviour
{
    public int selectedShip;
    public int selectedMaterial;

    private void Awake()
    {
        int numMusicPlayer = FindObjectsOfType<SavedShip>().Length;
        if (numMusicPlayer > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void saveShip()
    {
        selectedShip = Garagepannel.shipNumber;
        selectedMaterial = Garagepannel.materialNumber;
    }

}
