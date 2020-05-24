using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserCode : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform LaserHit;
    public float laserWait = 5.0f;
    

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;
        lineRenderer.useWorldSpace = true;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
        Debug.DrawLine(transform.position, hit.point);
        LaserHit.position = hit.point;
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, LaserHit.position);

        laserWait -= Time.deltaTime;
        //lineRenderer.enabled = false;
        if (laserWait<0)
        {
            lineRenderer.enabled = !(lineRenderer.enabled);
            laserWait = 5.0f;
            
            
        }
    }


}
