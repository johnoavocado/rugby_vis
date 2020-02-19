using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public delegate void OnUpdateStep(int step);
public class PlayController : MonoBehaviour
{
    private int _step;
    private int _steps;

    public static event OnUpdateStep UpdateStep;

    public BallController ball;
    public PlayerController ballStartsWith;

    private bool _locked;
    
    private void Start()
    {
        _step = 0;
        _steps = 3;
        _locked = false;
        
        ball.Pass(ballStartsWith);
    }

    void Increment()
    {
        if ( (_step + 1) < _steps ) _step++;
        UpdateStep?.Invoke(_step);
    }

    void Decrement()
    {
        if ( (_step - 1) >= 0 ) _step--;
        UpdateStep?.Invoke(_step);
    }

    private void OnEnable()
    {
        InputController.OnIncrement += Increment;
        InputController.OnDecrement += Decrement;
    }

    private void OnDisable()
    {
        InputController.OnIncrement -= Increment;
        InputController.OnDecrement -= Decrement;
    }
}
