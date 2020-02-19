using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void OnButtonPressDelegate();
public delegate void OnNumericPressDelegate(int num);
public class InputController : MonoBehaviour
{
    public static event OnButtonPressDelegate OnIncrement;
    public static event OnButtonPressDelegate OnDecrement;
    public static event OnButtonPressDelegate OnNumbersToggle;
    
    public static event OnNumericPressDelegate OnNumeric;

    public static InputController _instance;

    private void Start()
    {
        if( _instance == null ) _instance = this;
        else Destroy(this);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            OnIncrement?.Invoke();
        }
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            OnDecrement?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)) OnNumeric?.Invoke(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) OnNumeric?.Invoke(1);
        if (Input.GetKeyDown(KeyCode.Alpha3)) OnNumeric?.Invoke(2);
        if (Input.GetKeyDown(KeyCode.Alpha4)) OnNumeric?.Invoke(3);
        
        
        if (Input.GetKeyDown(KeyCode.N))
        {
            OnNumbersToggle?.Invoke();
        }
    }
}
