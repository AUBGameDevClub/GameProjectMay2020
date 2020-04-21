using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{  //when collision, "consume" powerup
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            Destroy(this.gameObject);
        }
    }
}
