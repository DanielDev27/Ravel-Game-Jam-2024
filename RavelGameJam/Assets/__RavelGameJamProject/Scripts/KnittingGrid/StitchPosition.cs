using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StitchPosition : MonoBehaviour
{
    // Start is called before the first frame update
    public static StitchPosition instance;
    private Transform stitchTransform;
    public string stitchParent;
    [SerializeField] Vector3 stitchPosition;
    public string slotName;
    private StitchAssignment stitchAssignment;

    public StitchSlot currentStitchSlot;
    private void Start()
    {
        instance = this;
        stitchTransform = GetComponent<Transform>();// get the item transform
        stitchPosition = stitchTransform.localPosition;//set the item position
        if (stitchTransform.parent != null)
        {
            stitchParent = stitchTransform.transform.parent.ToString();//parent slot of the item
            slotName = stitchTransform.transform.parent.name;//name of the slot
        }
        //Debug.Log(stack.ToString());
        //Debug.Log(slotTransform.transform.parent);
    }
    private void Update()
    {
        SlotPosition();//update the item position
        SlotName();//update the item name
        ItemParent();//update the item parent
    }
    public string SlotName()//state the name of the Item
    {
        slotName = stitchTransform.transform.parent.name;
        return slotName;
    }
    public string ItemParent()//parent name of the Item
    {
        stitchParent = stitchTransform.transform.parent.ToString();
        return stitchParent;
    }
    public Vector3 SlotPosition()//state the position of the item
    {
        stitchPosition = GetComponent<RectTransform>().position;
        return stitchPosition;
    }

}
