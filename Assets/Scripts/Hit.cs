using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{

    // public ParticleSystem explodingMechoid;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            // Instantiate(explodingMechoid, collision.gameObject.transform.position, collision.gameObject.transform.rotation);

            Animator animator = collision.gameObject.GetComponent<Animator>();
            Destroy(gameObject);
            animator.SetBool("isHit", true);
            Debug.Log("HIT");
        }
    }
}
