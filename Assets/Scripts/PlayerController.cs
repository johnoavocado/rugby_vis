using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using DG.Tweening;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TeamAlignment teamAlignment;

    [SerializeField]
    private MeshRenderer[] teamColourables;

    public Transform playerbody;

    public Transform hands;
    
    public GameObject TextMeshPro;

    
    void Start()
    {
        foreach (MeshRenderer kit in teamColourables )
        {
            kit.material = teamAlignment.TeamColours;
        }
        
        // Turn the player around
        Vector3 facing = playerbody.rotation.eulerAngles;
        facing.y = teamAlignment.orientation;
        playerbody.eulerAngles = facing;

        TextMeshPro.SetActive(teamAlignment.displaytext);
    }

    public void Move( Vector3 destination )
    {
        playerbody.DOMove(destination, 1.0f);
    }
    
}
