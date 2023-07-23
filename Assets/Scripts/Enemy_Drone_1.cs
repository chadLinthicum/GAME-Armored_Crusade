using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Drone_1 : MonoBehaviour
{
    public float speed = 150.0f;
    //public float zThreshold = 92.0f;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.localPosition.z);

        if (transform.localPosition.z > -815.0f)
        {
            Move();
        }
        else
        {
            Invoke("Move", 1.0f);
        }
        if (transform.localPosition.z < -1200.0f)
        {
            Destroy(gameObject);
        }
    }

    void Move()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
}
