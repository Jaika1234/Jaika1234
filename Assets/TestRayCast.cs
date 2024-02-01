using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestRayCast : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        GameObject clickedObject = eventData.pointerCurrentRaycast.gameObject;

        if (clickedObject != null)
        {
            Debug.Log("Clicked on UI object: " + clickedObject.name);
        }
        else
        {
            Debug.Log("No UI object clicked.");
        }
    }
}
