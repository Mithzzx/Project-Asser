using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlevel1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Loadlevel1", 84);
    }
    public void Loadlevel1()
    {
        SceneManager.LoadScene(0);
    }

}
