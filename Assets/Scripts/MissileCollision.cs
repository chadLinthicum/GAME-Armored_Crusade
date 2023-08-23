using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCollision : MonoBehaviour
{
    public GameObject explosionPrefab_Mechoid;
    public GameObject explosionPrefab_Wheelstinger;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Mechoid"))
        {
            Vector3 newPosition = collisionInfo.gameObject.transform.position;
            newPosition.y += 30f;
            newPosition.z += 30f;
            Instantiate(explosionPrefab_Mechoid, newPosition, Quaternion.identity);
            Destroy(collisionInfo.transform.parent.gameObject);
        }
        if (collisionInfo.gameObject.CompareTag("Wheelstinger"))
        {
            Vector3 newPosition = collisionInfo.gameObject.transform.position;
            Instantiate(explosionPrefab_Wheelstinger, newPosition, Quaternion.identity);
            Destroy(collisionInfo.transform.parent.gameObject);
        }
    }
}
