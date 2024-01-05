using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Cinemachine;

public class CollisionHandeler : MonoBehaviour
{
    [Header("Mesh")]
    [SerializeField] GameObject toDestroy;
    [SerializeField] GameObject toSpawn;
    [Header("Camera")]
    [SerializeField] CinemachineVirtualCamera cam;
    [SerializeField] GameObject toLook;
    [Header("Others")]
    [SerializeField] AudioClip crashSFX;
    [SerializeField] float reloadDelay = 1f;
    [SerializeField] GameObject CrashVFX;
    [SerializeField] GameObject collider;
    [SerializeField] TMP_Text DisplayWhenDead;
    [Tooltip("Text To Display When Dead")]
    [SerializeField]string DeadText;


    [System.Obsolete]
    private void OnCollisionEnter(Collision others)
    {
        if (others.gameObject.tag != "Frindly")
        {
            StartCrashSequance();
        }
        
    }

    [System.Obsolete]
    void StartCrashSequance()
    {
        
        CrashVFX.gameObject.SetActive(true);

        toDestroy.GetComponent<MeshRenderer>().enabled = false;
        collider.gameObject.SetActive(false);
        toSpawn.gameObject.SetActive(true);

        cam.Follow = toLook.transform;
        cam.LookAt = toLook.transform;

        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<PlayerControll>().enabled = false;

        DisplayWhenDead.text = DeadText;
        Invoke("ReloadScene", reloadDelay);
    }
    void ReloadScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

 }
