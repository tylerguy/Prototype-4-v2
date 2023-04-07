using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public bool isMoving = false;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player 1" || collision.gameObject.tag == "Player 2")
        {
            collision.gameObject.transform.parent = transform;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player 1" || collision.gameObject.tag == "Player 2")
        {
            collision.gameObject.transform.parent = null;
        }
    }
}
