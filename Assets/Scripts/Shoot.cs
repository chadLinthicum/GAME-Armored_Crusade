using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject missile;
    public Transform muzzle;

    public float speed = 125000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(missile, muzzle.position, muzzle.rotation);
            bullet.GetComponent<Rigidbody>().velocity = muzzle.forward * speed;
        }
    }
}
