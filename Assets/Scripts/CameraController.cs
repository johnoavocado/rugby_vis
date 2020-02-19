using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraController : MonoBehaviour
{
    public Transform[] cameraPositions;

    private Transform _transform;
    
    private void Start()
    {
        _transform = this.transform;
    }

    void MoveToCameraPosition( int pos )
    {
        if (pos < cameraPositions.Length)
        {
            var tmp = cameraPositions[pos];
            _transform.DOMove(tmp.position, 1.0f);
            _transform.DORotate(tmp.rotation.eulerAngles, 1.0f);
            _transform.parent = tmp;
        }
    }

    private void OnEnable()
    {
        InputController.OnNumeric += MoveToCameraPosition;
    }

    private void OnDisable()
    {
        if(InputController._instance) InputController.OnNumeric -= MoveToCameraPosition;
    }    
}
