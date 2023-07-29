using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechoid : MonoBehaviour
{
    public float speed = 150.0f;
    public float zStop = 100.0f;
    public float boundary = -1200.0f;

    [Tooltip("The distance from zStop that the drone starts decelerating / stops accelerating")]
    public float accelerationDistance = 10f;
    [Tooltip("Minimum speed during acceleration and deceleration, needs to be > 0 to avoid problem reaching and leaving the stop point")]
    [Min(0.1f)]
    public float minimumSpeed = 1.5f;
    [Tooltip("The curve of speed over distance from stop point")]
    public AnimationCurve accelerationCurve;
    
    private bool fired = false;
    private Animator childAnimator;

    void Start()
    {
        childAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zStop)
        {
            Move();
        }
        if (transform.position.z < zStop && fired == false)
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
        var actualSpeed = speed;
        var positionZ = transform.position.z;
        var offset = Mathf.Abs(positionZ - zStop);
        if (offset < accelerationDistance)
        {
            var positionOnDecelerationPath = offset / accelerationDistance;
            actualSpeed = Mathf.Lerp(minimumSpeed, speed,accelerationCurve.Evaluate(positionOnDecelerationPath));
        }
        transform.position += Vector3.back * actualSpeed * Time.deltaTime;
        childAnimator.SetBool("isMoving", true);
    }
    void StartMovingAgain()
    {
        childAnimator.SetBool("isMoving", true);
        fired = true;
    }
    void CheckBounds()
    {
        if (transform.localPosition.z < boundary)
        {
            Destroy(gameObject);
        }
    }
}
