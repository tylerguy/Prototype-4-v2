using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Button : MonoBehaviour
{
    public GameObject platform;
    public bool active = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player " + other.gameObject.name + " has pressed a button!");
        if (other.gameObject.tag == "Player 1")
        {
            active = true;
            // get waypoint manager attached to platform
            WaypointManager waypointManager = platform.GetComponent<WaypointManager>();
            // set waypoint manager to active
            waypointManager.active = true;
            // half the size of the button to make it look like it's been pressed
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
        }

    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Player " + other.gameObject.name + " has left a button!");
        if (other.gameObject.tag == "Player 1")
        {
            active = false;
            // get waypoint manager attached to platform
            WaypointManager waypointManager = platform.GetComponent<WaypointManager>();
            // set waypoint manager to inactive
            waypointManager.active = false;
            // double the size of the button to make it look like it's been released
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y * 2, transform.localScale.z);
        }
    }
}
