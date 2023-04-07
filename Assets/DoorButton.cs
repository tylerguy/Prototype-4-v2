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

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Player " + collision.gameObject.name + " has pressed a button!");
        // get current color of door
        Color currentColor = door.GetComponent<MeshRenderer>().material.color;
        // make the door transparent
        door.GetComponent<MeshRenderer>().material.color = new Color(currentColor.r, currentColor.g, currentColor.b, 0.5f);
        // change the door's layer to "Player 1" if the door was blue and "Player 2" if the door was red
        if (currentColor == Color.blue)
        {
            door.layer = 6;
        }
        else if (currentColor == Color.red)
        {
            door.layer = 7;
        }

    }

}
