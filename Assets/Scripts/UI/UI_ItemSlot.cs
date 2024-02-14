using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_ItemSlot : MonoBehaviour,IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI itemText;

    private UI ui;
    public InventoryItem item;
    private void Start()
    {
        ui = GetComponentInParent<UI>();
    }
    public void UpdataSlot(InventoryItem _newItem)
    {
        item = _newItem;

        itemImage.color= Color.white;

        if(item != null )
        {
            itemImage.sprite = item.data.icon;
            if(item.stackSize > 1)
            {
                itemText.text = item.stackSize.ToString();
            }
            else
            {
                itemText.text = "";
            }
        }
    }
    public void CleanUpSlot()
    {
        item = null;
        itemImage.color= Color.clear;
        itemText.text = "";
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        if (item == null || item.data == null)
            return;


        if (Input.GetKey(KeyCode.LeftControl))
        {
            Inventory.instance.RemoveItem(item.data);
            return;
        }

        if (item.data.itemType == ItemTpye.Equipment)
        {
            Inventory.instance.EquipItem(item.data);
            ui.itemToolTip.HideToolTip();
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        //if(item.data.itemType == ItemTpye.Equipment)
        if (item == null)
            return;

        Debug.Log("Show Item Info");
        ui.itemToolTip.ShowToolTip(item.data as ItemData_Equipment);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //if (item.data.itemType == ItemTpye.Equipment)
        if (item == null)
            return;
        Debug.Log("Hide Item Info ");
        ui.itemToolTip.HideToolTip();
    }

}
