using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform laserHit;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;
        lineRenderer.useWorldSpace = true;
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
        Debug.DrawLine(transform.position, hit.point);
        laserHit.position = hit.point;
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, laserHit.position);

       
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        lineRenderer.enabled = true;
        yield return new WaitForSeconds(2);
        lineRenderer.enabled = false;

    }

    private void FixedUpdate() //did not work
    {
      //wait();
    }
    
}


