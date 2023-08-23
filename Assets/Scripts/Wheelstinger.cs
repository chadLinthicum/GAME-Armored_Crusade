using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheelstinger : MonoBehaviour
{
    public float speed = 150.0f;
    public float boundary = -1200.0f;

    private GameObject player;
    private Vector3 playerPos;

    public GameObject explosionPrefab_Wheelstinger;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player_Bottom");

    }

    void Update()
    {
        Move();
        CheckBounds();
    }

    void Move()
    {
        playerPos = player.transform.position;
        transform.position += (playerPos - transform.position).normalized * speed * Time.deltaTime;
        transform.LookAt(player.transform.position);
        transform.Rotate(Vector3.up, 180f);
    }
    void CheckBounds()
    {
        if (transform.localPosition.z < boundary)
        {
            Destroy(gameObject);
        }
    }
}
