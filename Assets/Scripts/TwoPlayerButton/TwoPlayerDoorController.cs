using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPlayerDoorController : MonoBehaviour
{
    public bool Player1 = false;
    public bool Player2 = false;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Player1 && Player2)
        {
            Color currentColor = door.GetComponent<MeshRenderer>().material.color;
            Debug.Log("Both players are ready");
            door.GetComponent<MeshRenderer>().material.color = new Color(currentColor.r, currentColor.g, currentColor.b, 0.5f);
            door.layer = 8;

        }


    }
}
