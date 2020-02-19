using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BallController : MonoBehaviour
{
    public PlayerController[] passingWayPoints;

    private Transform _transform;

    private void OnEnable()
    {
        _transform = this.transform;
        PlayController.UpdateStep += Pass;
    }

    private void OnDisable()
    {
        PlayController.UpdateStep -= Pass;
    }

    public void Pass(PlayerController destinationPC)
    {
        _transform.DOMove(destinationPC.hands.position, 1.0f);
        _transform.parent = destinationPC.hands;
    }

    public void Pass(int step)
    {
        if (step >= 0 && step < passingWayPoints.Length)
        {
            Pass(passingWayPoints[step]);
            return;
        }
        Debug.Log("trying to pass to a waypoint outside of array range");
    }
    
}
