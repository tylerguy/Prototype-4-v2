using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointManager : MonoBehaviour
{
    public Vector3[] waypoints;

    // spawn gizmo at each waypoint that can be adjusted in the scene view
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        for (int i = 0; i < waypoints.Length; i++)
        {
            Gizmos.DrawSphere(waypoints[i], 0.5f);
        }
    }
}
