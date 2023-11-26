using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{



    public void GameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ControlScene()
    {
        SceneManager.LoadScene("ControlScene");
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
