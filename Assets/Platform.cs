using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 0.5f;
    public bool isMoving = false;

    public Rigidbody rb;

    private int currentWaypoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            if (currentWaypoint < GameObject.Find("waypointManager").GetComponent<waypointManager>().waypoints.Length)
            {
                Vector3 target = GameObject.Find("waypointManager").GetComponent<waypointManager>().waypoints[currentWaypoint];
                Vector3 direction = target - transform.position;
                rb.velocity = direction.normalized * speed;
                if (Vector3.Distance(transform.position, target) < 0.1f)
                {
                    currentWaypoint++;
                }
            }
            else
            {
                currentWaypoint = 0;
            }
        }
    }
}
