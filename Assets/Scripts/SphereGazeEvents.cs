using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGazeEvents : MonoBehaviour
{
    // This event is going to be fired when we look at the sphere
    public void OnGazeEnter()
    {
        Debug.Log("Gazered");
    }

    // This event is going to be fired when we stop looking at the sphere
    public void OnGazeLeave()
    {
        Debug.Log("Gaze");
    }
}
