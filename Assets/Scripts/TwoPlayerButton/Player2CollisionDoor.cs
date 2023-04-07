using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2CollisionDoor : MonoBehaviour
{
    public GameObject door;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player 2")
        {
            Debug.Log("Player 2 is ready");
            door.GetComponent<TwoPlayerDoorController>().Player2 = true;
        }
    }
}
