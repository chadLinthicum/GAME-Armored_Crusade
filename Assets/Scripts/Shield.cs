using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    public GameObject forcefield;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.x++;
        transform.position = newPos;
        transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Missile"))
        {
            Debug.Log("Missile");

        }
    }

}
