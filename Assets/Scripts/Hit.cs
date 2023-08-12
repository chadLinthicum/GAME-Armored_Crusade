using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public bool isHit = false;
    public GameObject mechoid;

    // public ParticleSystem explodingMechoid;

    // Start is called before the first frame update
    void Start()
    {
        mechoid = GameObject.FindWithTag("Mechoid");
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            mechoid.transform.position += Vector3.down * 35 * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            // Instantiate(explodingMechoid, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            //Animator animator = collision.gameObject.GetComponent<Animator>();
            //animator.SetBool("isHit", true);
            isHit = true;
            Debug.Log("HIT");
        }
    }
}
