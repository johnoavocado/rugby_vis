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
    }

    public void Pass(PlayerController destinationPC)
    {
        _transform.DOMove(destinationPC.hands.position, 1.0f);
        _transform.parent = destinationPC.hands;
    }
}
