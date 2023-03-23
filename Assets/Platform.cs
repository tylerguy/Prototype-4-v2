using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 0.5f;
    public bool isMoving = false;

    public Transform[] waypoints;

    private int currentWaypoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[currentWaypoint].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            // move between waypoints
            if (transform.position == waypoints[currentWaypoint].transform.position)
            {
                currentWaypoint++;
                if (currentWaypoint >= waypoints.Length)
                {
                    currentWaypoint = 0;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].transform.position, speed * Time.deltaTime);
        }
    }
}
