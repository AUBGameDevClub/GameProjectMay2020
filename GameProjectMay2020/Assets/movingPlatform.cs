using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    private Vector3 _startPosition;
    public float speed;
    void Start()
    {
        _startPosition = transform.position;
    }

    void Update()
    {
        Vector3 _newPosition = transform.position;
        _newPosition.x += Mathf.Sin(Time.time) * Time.deltaTime * speed;
        transform.position = _newPosition;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.parent = transform;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        other.transform.parent = null;
    }
}
