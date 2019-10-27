using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("MiniGame");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Exit");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Intro");
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}

