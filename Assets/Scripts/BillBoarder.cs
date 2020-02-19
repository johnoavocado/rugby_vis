using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoarder : MonoBehaviour
{
    private Camera cam;
    private Canvas canvas;
    private void Start()
    {
        canvas = this.GetComponent<Canvas>();
        canvas.worldCamera = Camera.main;
        cam = Camera.main;
    }

    void Update()
    {
        var rot = cam.transform.rotation;
        Vector3 vr = rot.eulerAngles;
        vr.x += -90;
        rot.eulerAngles = vr;
        transform.rotation = rot;
    }

    void ToggleDisplay()
    {
        canvas.enabled = !canvas.enabled;
    }
    
    private void OnEnable() => InputController.OnNumbersToggle += ToggleDisplay;
    private void OnDisable() => InputController.OnNumbersToggle -= ToggleDisplay;
    
}
