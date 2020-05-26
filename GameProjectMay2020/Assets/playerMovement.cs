using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 10f;

    float horizontalMove = 0f;
    float verticalMove = 0f;
    bool jump = false;
    bool crouch = false;
    bool canClimb = false;

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        verticalMove = Input.GetAxisRaw("Vertical") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        

    }

    void FixedUpdate()
    {
        Debug.Log(controller);
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        controller.tryToClimb(verticalMove * Time.deltaTime, canClimb);
        jump = false;
        canClimb = false;
    }

    void ableToClimb()
    {
        canClimb = true;
    }
     
    void die()
    {
        controller.runDeathAnimation();
    }
}