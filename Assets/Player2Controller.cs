using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2Controller : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 5.0f;
    public float jumpForce;
    public bool isGrounded = true;

    public Camera cam;

    private Vector2 move;
    private Vector2 look;

    public bool jump;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    // Update is called once per frame
    // void FixedUpdate()
    // {
    //     if (Input.GetKey(KeyCode.W))
    //     {
    //         rb.AddForce(transform.forward * speed);
    //     }
    //     else if (Input.GetKey(KeyCode.S))
    //     {
    //         rb.AddForce(-transform.forward * speed);
    //     }
    //     if (Input.GetKeyDown(KeyCode.A))
    //     {
    //         rb.AddForce(-transform.right * speed);
    //     }
    //     else if (Input.GetKey(KeyCode.D))
    //     {
    //         rb.AddForce(transform.right * speed);
    //     }
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         if (isGrounded)
    //         {
    //             GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    //             isGrounded = false;
    //         }
    //     }
    // }

    public void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }

    public void OnLook(InputValue value)
    {
        look = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        jump = value.isPressed;
    }

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(move.x, 0, move.y);
        Vector3 rotation = new Vector3(0, look.x, 0);

        cam.transform.Rotate(-look.y * rotationSpeed * Time.deltaTime, 0, 0);

        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
        transform.Translate(direction * speed * Time.deltaTime, Space.Self);
        if (jump)
        {
            if (isGrounded)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isGrounded = false;
                jump = false;
            }
        }
    }
}
