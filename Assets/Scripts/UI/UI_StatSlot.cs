using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_StatSlot : MonoBehaviour
{
    [SerializeField] private string statName;

    [SerializeField] private  StatType statType;
    [SerializeField] private TextMeshProUGUI statValueText;
    [SerializeField] private TextMeshProUGUI statNameText;

    private void OnValidate()
    {
        gameObject.name = "Stat - " + statName;

        if (statNameText != null)
            statNameText.text = statName;    
        
    }
     void Start()
    {
        UpdateStatValueUI();
    }
    public void UpdateStatValueUI()
    {
        PlayerStats playerState = PlayerManager.instance.player.GetComponent<PlayerStats>();

        if(playerState != null)
        {
            statValueText.text = playerState.GetStat(statType).GetValue().ToString();
        }

    }


}
