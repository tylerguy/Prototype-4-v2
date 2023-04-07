using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1CollisionDoor : MonoBehaviour
{
    public GameObject door;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player 1")
        {
            Debug.Log("Player 1 is ready");
            door.GetComponent<TwoPlayerDoorController>().Player1 = true;
        }
    }
}
