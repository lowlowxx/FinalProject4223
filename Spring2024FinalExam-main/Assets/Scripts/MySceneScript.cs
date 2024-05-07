using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MySceneScript : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Intro");
    }

    public void InGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Exit");
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.ExitPlaymode();

    }
}
