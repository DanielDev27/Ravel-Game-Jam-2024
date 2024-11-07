using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class StitchSlot : MonoBehaviour
{
    // Start is called before the first frame update
    public static StitchSlot instance;
    private Transform slotTransform;
    [SerializeField] Vector3 slotPosition;
    public string slotName;
    private StitchPosition currentStitch;
    private StitchAssignment stitchAssignment;
    [SerializeField] bool read;
    [SerializeField] public Stitch assignedStitch;
    [SerializeField] public Stitch blankStitch;
    [SerializeField] public Stitch redStitch;
    [SerializeField] public Stitch whiteStitch;
    private void Start()
    {
        instance = this;
        slotTransform = GetComponent<Transform>();
        slotPosition = slotTransform.localPosition;
        slotName = GetComponent<Transform>().name;
        if (!read)
        {
            assignedStitch = blankStitch;
        }
        if (assignedStitch != null)
        {
            AssignSprite();
        }
    }
    public string SlotName()//state the name of the inventory slot
    {
        return slotName;
    }
    public Vector3 SlotPosition()//state the position of the inventory slot
    {
        return slotPosition;
    }
    private void Update()
    {
        slotPosition = GetComponent<Transform>().position;//update the lost position
        SlotName();//update the slot name
    }
    public void AssignSprite()
    {
        Image slotImage = this.GetComponentInChildren<Image>();
        slotImage.sprite = assignedStitch.getSprite();
    }

}
