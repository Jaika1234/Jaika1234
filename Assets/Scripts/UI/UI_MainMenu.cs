using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{
    [SerializeField] private string sceneName = "MainScene";

    public void NewGame()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void ExitGame()
    {
        Debug.Log("exitgame");
    }

}
