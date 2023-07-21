using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 30.0f;
    //private float xRange = 16.0f;
    //private float zRangeBottom = -4.0f;
    //private float zRangeTop = 16.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move object horizontally based on mouse movement

        // Keep the player in bounds
        //if (transform.position.x < -xRange)
        //{
        //    transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        //}
        //if (transform.position.x > xRange)
        //{
        //    transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        //}

        //if (transform.position.z < zRangeBottom)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, zRangeBottom);
        //}
        //if (transform.position.z > zRangeTop)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, zRangeTop);
        //}

        // Player input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(transform.right * horizontalInput * Time.deltaTime * speed);

        //verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);


        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        //}
    }
}

