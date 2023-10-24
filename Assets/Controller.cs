using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float initForce;
    Rigidbody rb;
    public float speed = 45.0f; // Speed of rotation in degrees per second
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(initForce, 0, 0);
    }

    private void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.AddForce(horizontalInput * speed, 0, verticalInput * speed);
    }
}
