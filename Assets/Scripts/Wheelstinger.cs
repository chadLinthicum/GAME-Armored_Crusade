using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheelstinger : MonoBehaviour
{
    public float speed = 150.0f;
    public float boundary = -1200.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    void Move()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
    void CheckBounds()
    {
        if (transform.localPosition.z < boundary)
        {
            Destroy(gameObject);
        }
    }
}
