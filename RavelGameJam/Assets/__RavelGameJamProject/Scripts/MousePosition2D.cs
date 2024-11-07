using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MousePosition2D : MonoBehaviour
{
    public static MousePosition2D Instance;
    [SerializeField] public Camera camera;
    [SerializeField] LayerMask interactionLayer;
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(camera.ScreenToWorldPoint(Mouse.current.position.ReadValue()).x, camera.ScreenToWorldPoint(Mouse.current.position.ReadValue()).y, 0);
        //Debug.Log(ray);

    }

}
