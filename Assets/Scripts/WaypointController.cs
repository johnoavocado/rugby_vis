using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointController : MonoBehaviour
{
    public MeshRenderer disappearMe;
    
    // Start is called before the first frame update
    void Start()
    {
        disappearMe.enabled = false;
    }
    
}
