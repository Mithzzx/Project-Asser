using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void Play(int level)
    {
        SceneManager.LoadScene(level+1);
    }
    public void Quitgame()
    {
        Application.Quit();
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadStory()
    {
        SceneManager.LoadScene(1);
    }

}
