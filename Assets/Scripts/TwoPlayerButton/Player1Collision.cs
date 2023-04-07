using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Collision : MonoBehaviour
{
    public GameObject TwoPlayerButton;

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player 1")
        {
            Debug.Log("Player 1 is ready");
            TwoPlayerButton.GetComponent<TwoPlayerButton>().Player1 = true;
        }
    }
}
