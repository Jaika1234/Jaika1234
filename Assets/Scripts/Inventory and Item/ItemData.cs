using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemTpye
{
    Marterial,
    Equipment
}
[CreateAssetMenu(fileName ="New Item Data",menuName = "Data/Item")]
public class ItemData : ScriptableObject
{
    public ItemTpye itemType;
    public string itemName;
    public Sprite icon;

    [Range(0,100)]
    public float dropChance;
}
