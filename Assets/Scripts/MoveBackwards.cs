using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackwards : MonoBehaviour
{
    public float speed;
    private PlayerController playerControllerScript;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
