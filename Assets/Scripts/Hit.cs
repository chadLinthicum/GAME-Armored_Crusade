using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public GameObject explosionPrefab_Mechoid;
    public GameObject explosionPrefab_Wheelstinger;

    //private GameObject mechoid;

    void Start()
    {
        // FIXME: this could be "any" enemy,
        // not neccessarily the one that got hit
        //mechoid = GameObject.FindWithTag("Mechoid");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mechoid"))
        {
            Vector3 newPosition = collision.gameObject.transform.position;
            newPosition.y += 30f;
            newPosition.z += 30f;
            if (explosionPrefab_Mechoid) Instantiate(explosionPrefab_Mechoid, newPosition, Quaternion.identity);
            Destroy(collision.transform.parent.gameObject);
            Debug.Log("HIT");
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Wheelstinger"))
        {
            Vector3 newPosition = collision.gameObject.transform.position;
            //newPosition.z += 10f;
            if (explosionPrefab_Wheelstinger) Instantiate(explosionPrefab_Wheelstinger, newPosition, Quaternion.identity);
            Destroy(collision.transform.parent.gameObject);

            Debug.Log("HIT");
            Destroy(gameObject);
        }
    }
}