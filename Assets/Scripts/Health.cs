using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 3;

    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy_Projectile"))
        {
            health--;
            Debug.Log("Health: " + health);
            Destroy(other.gameObject);
        }
    }
}
