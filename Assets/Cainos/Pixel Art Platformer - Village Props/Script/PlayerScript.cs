using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float runSpeed = 5;
    public float jumpForce = 300;
    public Rigidbody2D rb;

    public ground_checker groundChecker;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        //Debug.Log($"Input value: {moveInput}");
        if(Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        }
       
        if (Input.GetKeyDown(KeyCode.Space) && groundChecker.isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }
   
}
