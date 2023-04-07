using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    public Vector3[] waypoints;
    public float speed = 0.5f;
    public int currentWaypoint = 0;

    public bool active = false;

    // spawn gizmo at each waypoint that can be adjusted in the scene view
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        for (int i = 0; i < waypoints.Length; i++)
        {
            Gizmos.DrawSphere(waypoints[i], 0.5f);
        }
    }

    void Start()
    {
        // set platform to first waypoint
        transform.position = waypoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            GetComponent<Platform>().isMoving = true;
            // move the platform to the next waypoint
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint], speed * Time.deltaTime);
            // if the platform has reached the waypoint
            if (transform.position == waypoints[currentWaypoint])
            {
                // if the platform has reached the last waypoint
                if (currentWaypoint == waypoints.Length - 1)
                {
                    // move back the sequence of waypoints
                    System.Array.Reverse(waypoints);
                    // set the platform to the first waypoint
                    currentWaypoint = 0;

                }
                else
                {
                    // set the platform to the next waypoint
                    currentWaypoint++;
                }
            }

        }
        GetComponent<Platform>().isMoving = true;
    }
}
