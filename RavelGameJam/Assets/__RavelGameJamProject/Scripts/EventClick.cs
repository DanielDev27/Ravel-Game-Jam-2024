using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

//Add this to the game objects you want to click on
public class EventClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    void Start()
    {
    }
    void Update()
    {

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("Interact with " + this.gameObject.transform.parent.name + "-" + this.gameObject.name);
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            this.gameObject.GetComponent<StitchSlot>().assignedStitch = this.gameObject.GetComponent<StitchSlot>().redStitch;
            this.gameObject.GetComponent<StitchSlot>().AssignSprite();
            Debug.Log("Interact with " + this.gameObject.transform.parent.name + "-" + this.gameObject.name + "Set Red");
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            this.gameObject.GetComponent<StitchSlot>().assignedStitch = this.gameObject.GetComponent<StitchSlot>().whiteStitch;
            this.gameObject.GetComponent<StitchSlot>().AssignSprite();
            Debug.Log("Interact with " + this.gameObject.transform.parent.name + "-" + this.gameObject.name + "Set White");
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Enter " + this.gameObject.name);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //
    }
}
