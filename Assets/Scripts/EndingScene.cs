using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour
{
    public void MenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
