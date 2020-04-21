using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))] //gets the rigid component
public class playerMovement : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded; //checks if on ground, prevents infinite ascend 3end allah

    Rigidbody rb; //your player

    [SerializeField]
    private
        float _speedHorizontal; //speed along x

    [SerializeField]
    private
        float _speedVertical; //speed along y

    public Vector2 startPos;

    // Start is called before the first frame update
    void Start()

    {   //set start position
        startPos = new Vector3(0, 0, 0);
        transform.position = startPos;

        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);


    }

    void OnCollisionStay() //again, checks if on ground. needed for jumping
    {
        isGrounded = true;
    }

    void OnCollisionExit()
    {
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal speed, input in Unity
        float horizInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizInput, 0, 0) * _speedHorizontal * Time.deltaTime);

        //Vertical speed, input in Unity
        float vertInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, vertInput, 0) * _speedVertical * Time.deltaTime);

        //double speed when shift pressed down
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(new Vector3(horizInput, 0, 0) * (_speedHorizontal * 2) * Time.deltaTime);
            transform.Translate(new Vector3(0, vertInput, 0) * (_speedVertical * 2) * Time.deltaTime);
        }

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump*jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
