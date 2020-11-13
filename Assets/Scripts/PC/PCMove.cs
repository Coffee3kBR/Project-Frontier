﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCMove : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator;

    public float speed;
    public float gravity;

    Vector3 velocity;
    
    public Transform groundCheck;
    public float goundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, goundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        
        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical", move.z);
        animator.SetFloat("Magnitude", move.magnitude);
    }
}
