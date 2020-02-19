using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class PlayerPath : MonoBehaviour
{
    public Transform[] waypoints;
    public PlayerController playerController;

        
    void Move(int step)
    {
        playerController.Move(waypoints[step].position);
    }

    

    private void OnEnable()
    {
        PlayController.UpdateStep += Move;
    }
    
    private void OnDisable()
    {
        PlayController.UpdateStep -= Move;
    }
}
