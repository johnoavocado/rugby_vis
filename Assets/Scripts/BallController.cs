using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BallController : MonoBehaviour
{
    void Pass(PlayerController destinationPC)
    {
        this.transform.DOMove(destinationPC.transform.position, 1.0f);
    }
}
