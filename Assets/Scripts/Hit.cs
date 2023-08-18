using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public bool isHit = false;
    public GameObject explosionPrefab;

    private GameObject mechoid; 

    // public ParticleSystem explodingMechoid;

    // Start is called before the first frame update
    void Start()
    {
        // FIXME: this could be "any" enemy,
        // not neccessarily the one that got hit
        mechoid = GameObject.FindWithTag("Mechoid");
    }

    // Update is called once per frame
    void Update()
    {
        // FIXME: this code will never run because this object
        // is destroyed the exact same moment isHit becomes true
        if (isHit)
        {
            mechoid.transform.position += Vector3.down * 35 * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            if (explosionPrefab) Instantiate(explosionPrefab, collision.gameObject.transform.position, Quaternion.identity);
            
            // Instantiate(explodingMechoid, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            //Animator animator = collision.gameObject.GetComponent<Animator>();
            //animator.SetBool("isHit", true);
            isHit = true;
            Debug.Log("HIT");
            Destroy(gameObject);
        }
    }
}