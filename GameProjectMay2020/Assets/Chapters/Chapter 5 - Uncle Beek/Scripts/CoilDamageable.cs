using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoilDamageable : MonoBehaviour
{

    Animator animator;
    GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        //Connect script to empty child to act as trigger and reference parent
        parent = gameObject.transform.parent.gameObject;
        animator = parent.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void OnTriggerStay2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            //Animation Stuff
            animator.SetBool("activated",true);

            //CODE FOR DAMAGING THE PLAYER...
        }


    }
    void OnTriggerExit2D()
    {

        animator.SetBool("activated", false);

    }

    
}
