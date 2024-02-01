using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_EquipmentSlot : UI_ItemSlot
{
    public EquipmentTpye slotType;

    private void OnValidate()
    {
        gameObject.name= "Equipment Slot " +slotType.ToString();
    }

}
