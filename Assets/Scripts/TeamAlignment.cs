using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/TeamAlignment")]
public class TeamAlignment : ScriptableObject
{
    public Material TeamColours;
    public float orientation;
    public bool displaytext;
}