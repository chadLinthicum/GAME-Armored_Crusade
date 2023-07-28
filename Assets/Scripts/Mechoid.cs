using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechoid : MonoBehaviour
{
    public float speed = 150.0f;
    public float zThreshold = 100.0f;
    public float backBound = -1200.0f;
    private Animator childAnimator;
    private bool fired = false;

    void Start()
    {
        childAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zThreshold)
        {
            Move();
        }
        if (transform.position.z < zThreshold && fired == false)
        {
            childAnimator.SetBool("isMoving", false);

            //TODO - Code for firing attack

            Invoke("StartMovingAgain", 2.0f);

        }
        if (fired == true)
        {
            Move();
        }

        CheckBounds();
    }

    void Move()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
        childAnimator.SetBool("isMoving", true);
    }
    void StartMovingAgain()
    {
        childAnimator.SetBool("isMoving", true);
        fired = true;
    }
    void CheckBounds()
    {
        if (transform.localPosition.z < backBound)
        {
            Destroy(gameObject);
        }
    }
}
