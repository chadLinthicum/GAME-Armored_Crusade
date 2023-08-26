using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheelstinger : MonoBehaviour
{
    public float speed = 150.0f;
    public float boundary = -1200.0f;

    private GameObject target;
    private Vector3 targetPos;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player_Bottom");
    }

    void Update()
    {
        Move();
        CheckBounds();
    }

    void Move()
    {
        targetPos = target.transform.position;
        transform.position += (targetPos - transform.position).normalized * speed * Time.deltaTime;
        transform.LookAt(target.transform.position);
        transform.Rotate(Vector3.up, 180f);
    }
    void CheckBounds()
    {
        if (transform.localPosition.z < boundary)
        {
            Destroy(gameObject);
        }
    }
}
