using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour, ISaveManager
{
    public static PlayerManager instance;
    public Player player;

    public void LoadData(GameData _data)
    {
        throw new System.NotImplementedException();
    }

    public void SaveData(ref GameData _data)
    {
        throw new System.NotImplementedException();
    }

    private void Awake()
    {
        if (instance != null)
            Destroy(instance.gameObject);
        else
            instance = this;
    }
}
