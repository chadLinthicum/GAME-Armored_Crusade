using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Drone_1 : MonoBehaviour
{
    public float speed = 150.0f;
    public float zThreshold = 90.0f;
    public float backBound = -1200.0f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zThreshold)
        {
            Move();
        }
        else
        {
            Invoke("Move", 1.0f);
        }
        if (transform.localPosition.z < backBound)
        {
            Destroy(gameObject);
        }
    }

    void Move()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
}
