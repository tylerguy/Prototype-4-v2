using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1CollisionDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject door;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        door.GetComponent<TwoPlayerDoorController>().Player2 = true;

    }
}
