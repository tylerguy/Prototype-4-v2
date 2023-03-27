using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public GameObject door;
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
        // open door
        door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y - 2, door.transform.position.z);
    }
}
