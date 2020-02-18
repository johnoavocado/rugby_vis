using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    public TeamAlignment teamAlignment;

    [SerializeField]
    private MeshRenderer[] teamColourables;

    private Transform _transform;
    
    void Start()
    {
        foreach (MeshRenderer kit in teamColourables )
        {
            kit.material = teamAlignment.TeamColours;
        }
        
        // Turn the player around
        _transform = this.transform;
        Vector3 facing = _transform.rotation.eulerAngles;
        facing.y = teamAlignment.orientation;
        _transform.eulerAngles = facing;
    }

    public void Move( Vector3 destination )
    {
        _transform.DOMove(destination, 1.0f);
    }
    
}
