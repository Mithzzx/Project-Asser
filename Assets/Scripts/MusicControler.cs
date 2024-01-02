using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MusicControler : MonoBehaviour
{
    MusicPlayer mp;
    [SerializeField] TMP_Text UiText;


    void Start()
    {
        mp = GameObject.Find("MusicPlayer").GetComponent<MusicPlayer>();
        UpdateText();
    }
    public void UpdateText()
    {
        UiText.text = mp.musicName;
    }
    public void PauseAudio()
    {
        mp.aSource.Pause();
    }
    public void ResumeAudio()
    {
        mp.aSource.Play();
    }
    public void PlayNext()
    {
        if (mp.trackIndex < mp.tracks.Length - 1)
        {
            mp.trackIndex++;
            UpdateAudioTrack(mp.trackIndex);
        }
    }

    public void PlayPrevious()
    {
        if (mp.trackIndex > 0)
        {
            mp.trackIndex--;
            UpdateAudioTrack(mp.trackIndex);            
        }
    }

    private void UpdateAudioTrack(int trackIndex)
    {
        mp.aSource.clip = mp.tracks[trackIndex].audioClip;
        mp.musicName = mp.tracks[trackIndex].audioClip.name;
        UpdateText();
        mp.aSource.Play();
    }

    public void UpdateVolume(float volume)
    {
        mp.aSource.volume = volume;
    }

}
