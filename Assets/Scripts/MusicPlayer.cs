using System;
using UnityEngine;
using TMPro;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] public Track[] tracks;
    public AudioSource aSource;
    public int trackIndex = 0;

    public String musicName;
    private void Awake()
    {
        int numMusicPlayer = FindObjectsOfType<MusicPlayer>().Length;
        if (numMusicPlayer > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }
    private void Start()
    {
        aSource = GetComponent<AudioSource>();

        aSource.clip = tracks[trackIndex].audioClip;
        musicName = tracks[trackIndex].audioClip.name;
        aSource.Play();
    }
}
