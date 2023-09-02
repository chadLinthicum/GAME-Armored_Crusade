using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForcefield : MonoBehaviour
{
    public GameObject explosionPrefab_Wheelstinger;
    public GameObject explosionPrefab_Generic;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Wheelstinger"))
        {
            Destroy(collisionInfo.gameObject);
            Instantiate(explosionPrefab_Wheelstinger, collisionInfo.gameObject.transform.position, Quaternion.identity);
        }
        if (collisionInfo.gameObject.layer == LayerMask.NameToLayer("Ouch"))
        {
            Destroy(collisionInfo.gameObject);
            Instantiate(explosionPrefab_Generic, collisionInfo.gameObject.transform.position, Quaternion.identity);
        }
    }

}
