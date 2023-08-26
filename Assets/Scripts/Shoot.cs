using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject missile;
    public Transform muzzle;
    public GameObject muzzleFlashFX;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = speed * 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (missile) {
                GameObject bullet = Instantiate(missile, muzzle.position, muzzle.rotation);
                bullet.GetComponent<Rigidbody>().velocity = muzzle.forward * speed;
                Destroy(bullet, 3f);
            }

            if (muzzleFlashFX) {
                Instantiate(muzzleFlashFX, muzzle.position, muzzle.rotation);
            }
        }
    }
}
