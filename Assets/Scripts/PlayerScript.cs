using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float runSpeed = 5;
    public float jumpForce = 300;
    public Rigidbody2D rb;
    public Pkayer_health health;

    private Animator animator;

    public ground_checker groundChecker;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = GetComponent<Pkayer_health>();
         animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health.isDead) return;
        float moveInput = Input.GetAxis("Horizontal");
        animator.SetBool("IsRunning", Mathf.Abs(moveInput) > 0.1f);
        //Debug.Log($"Input value: {moveInput}");
        if (Input.GetKey(KeyCode.LeftShift))
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
