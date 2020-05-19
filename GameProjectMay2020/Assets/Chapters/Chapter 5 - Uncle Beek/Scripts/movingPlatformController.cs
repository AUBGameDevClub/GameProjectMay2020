using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class movingPlatformController : MonoBehaviour
{
    //public parameters

    public float horizontal_amplitude = 1f;
    public float horizontal_period = 1f;
    public float vertical_amplitude = 1f;
    public float vertical_period = 1f;
    public float vertical_phase = 1f;

    Vector2 initialPos;
    float t = 0;



    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        Vector2 pos = transform.position;


        //Oscillate horizontally
        pos.x = initialPos.x + (float)(horizontal_amplitude * Math.Sin(t / horizontal_period));

        //Oscillate vertically
        pos.y = initialPos.y + (float)(vertical_amplitude * Math.Sin(t / vertical_period+vertical_phase));

        //submit position
        transform.position = pos;

    }

    
}
