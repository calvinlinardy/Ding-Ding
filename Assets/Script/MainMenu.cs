using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayEasy()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayMedium()
    {
        SceneManager.LoadScene(2);
    }

    public void PlayHard()
    {
        SceneManager.LoadScene(3);
    }

    public void PlayExtreme()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
