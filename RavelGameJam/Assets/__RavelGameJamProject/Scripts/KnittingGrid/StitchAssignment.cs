using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class StitchAssignment : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;
    private GameObject knittingUI;
    private Stitch stich;
    public Transform trans;
    private void Start()
    {
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
        trans = GetComponent<Transform>();
    }

    public void LeftClick(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            //set stitch to Red;
        }
    }
    public void RightClick(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            //set stitch to White;
        }
    }
}
