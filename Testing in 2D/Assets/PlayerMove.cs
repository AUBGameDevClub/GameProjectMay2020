using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {                                              // This 'Raw' here makes the movement accurate with no acceleration
        Vector2 moveInput = new Vector2(Input.GetAxis/*Raw*/("Horizontal"), Input.GetAxis/*Raw*/("Vertical"));
        moveVelocity = moveInput.normalized * Speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
