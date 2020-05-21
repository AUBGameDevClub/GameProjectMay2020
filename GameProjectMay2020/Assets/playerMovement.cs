using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))] //gets the rigid component
public class playerMovement : MonoBehaviour
{

    Rigidbody2D rb; //your player
    public float jump = 2.0f;

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
        startPos = new Vector2(0, 0);
        transform.position = startPos;
        rb = transform.GetComponent<Rigidbody2D>();

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jump;
        }
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Saw"))
        {
            startPos = new Vector2(0, 0);
            transform.position = startPos;
        }
    }
}
