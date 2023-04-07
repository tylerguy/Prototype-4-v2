using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPlayerButton : MonoBehaviour
{
    public bool Player1 = false;
    public bool Player2 = false;

    public GameObject platform;

    // Update is called once per frame


    void Update()
    {
        if (Player1 && Player2)
        {

            Debug.Log("Both players are ready");
            platform.GetComponent<WaypointManager>().active = true;

        }
    }
}
