using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelDrop : MonoBehaviour
{

    private GameObject player;
    public float playerPosZ;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerPosZ = player.transform.position.z;
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player);
        // Debug.Log(playerPosZ);
        // Debug.Log(transform.position.z);
        if (transform.position.z <= (playerPosZ + 200))
        {
            // Vector3 newPosition = transform.position;
            // newPosition.z = playerPosZ;
            // transform.position = newPosition;
            rigidbody.useGravity = true;
            rigidbody.AddForce(Vector3.down * 15f);
        }

    }
}
