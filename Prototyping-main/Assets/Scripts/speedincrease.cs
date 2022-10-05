using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedincrease : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;

    float horizontalInput;
    float verticalInput;

    private void FixedUpdate()
    {
        //   rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        rb.AddForce(new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed));
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 50);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");



        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }
}

