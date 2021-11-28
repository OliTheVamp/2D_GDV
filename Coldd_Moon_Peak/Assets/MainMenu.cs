using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //If clicked, Game begins
    public void PlayGame ()
    {
        SceneManager.LoadScene(1);
    }

    //If clicked, Game Quits
    public void QuitGame ()
    {
        Application.Quit();
    }
}
