﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    //COMPONENTS
    private Rigidbody2D rb;

    //Parameters for tuning in unity
    public float speed = 3f;
    public float jumpForce = 3f;
    public float numJumpsAllowed = 2;

    //variables
    bool canJump = false;
    float numJumps = 0;


    // Start is called before the first frame update
    void Start()
    {

        //Getting components ready
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //get current velocity
        Vector2 vel = rb.velocity;

        //check if grounded
        if(!canJump && Math.Abs(vel.y) < 0.02f)
        {
            canJump = true;
            numJumps = 0;
        }




        //Listening to user movement input
        
        float xMove = Input.GetAxis("Horizontal");      //horizontal movement
        bool toJump = Input.GetKeyUp(KeyCode.Space);

        
        if (toJump && canJump) jump();


        //Position Control

        vel = rb.velocity;
        vel.x = xMove * speed;
        rb.velocity = vel;

        










    }

    void jump()
    {
        
        Debug.Log("Jumping");

        Vector2 vel = rb.velocity;
        vel.y = jumpForce;
        rb.velocity = vel;

        numJumps++;

        if (numJumps == numJumpsAllowed)
        {
            canJump = false;
        }

    }

    

 
}
