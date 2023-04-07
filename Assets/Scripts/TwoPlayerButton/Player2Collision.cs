using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Collision : MonoBehaviour
{
    public GameObject TwoPlayerButton;
    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player 2")
        {
            Debug.Log("Player 2 is ready");
            TwoPlayerButton.GetComponent<TwoPlayerButton>().Player2 = true;
        }
    }
}
