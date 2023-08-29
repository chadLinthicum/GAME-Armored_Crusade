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
            Score.playerScore = Score.playerScore + 50;
            Vector3 newPosition = collisionInfo.gameObject.transform.position;
            newPosition.y += 30f;
            newPosition.z += 30f;
            Instantiate(explosionPrefab_Mechoid, newPosition, Quaternion.identity);
            Destroy(collisionInfo.transform.parent.gameObject);
        }
        if (collisionInfo.gameObject.CompareTag("Wheelstinger"))
        {
            Score.playerScore = Score.playerScore + 100;
            Vector3 newPosition = collisionInfo.gameObject.transform.position;
            Instantiate(explosionPrefab_Wheelstinger, newPosition, Quaternion.identity);
            Destroy(collisionInfo.transform.parent.gameObject);
        }
        //if (collisionInfo.gameObject.CompareTag("Beetlebomber"))
        //{
        //    Score.playerScore = Score.playerScore + 200;
        //    Vector3 newPosition = collisionInfo.gameObject.transform.position;
        //    Instantiate(explosionPrefab_Beetlebomber, newPosition, Quaternion.identity);
        //    Destroy(collisionInfo.transform.parent.gameObject);
        //}
    }
}
