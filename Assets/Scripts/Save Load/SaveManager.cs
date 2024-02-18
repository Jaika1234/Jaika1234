using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private GameData gameData;

    public static SaveManager instance;

    private void Awake()
    {
        if (instance != null)
            Destroy(instance.gameObject);
        else
            instance= this;
    }
    private void Start()
    {
        LoadGame();
    }


    public void NewGame()
    {
        gameData= new GameData();
    }
    public void LoadGame()
    {
        if(this.gameData == null)
        {
            Debug.Log("Data is null");
            NewGame();
        }
    }
    public void SaveGame()
    {
        Debug.Log("save the game");
    }
    private void OnApplicationQuit()
    {
        SaveGame();
    }

}
