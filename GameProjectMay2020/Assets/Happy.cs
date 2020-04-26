using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Happy : MonoBehaviour{

    private Rigidbody2D rigid;
    private float dirX, moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    private void FixedUpdate()
    {
        rigid.velocity = new Vector2(dirX, rigid.velocity.y);
    }
}
