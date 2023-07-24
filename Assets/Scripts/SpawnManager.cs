using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] mechoidPrefab;

    public float spawnY = 92.5f;
    public float spawnZ = 1100f;

    public Vector3[] positions;

    void Start()
    {
        positions = new Vector3[] {
            new Vector3(-115f, spawnY, spawnZ),
            new Vector3(-15f, spawnY, spawnZ),
            new Vector3(85f, spawnY, spawnZ)
        };
        InvokeRepeating("spawnMechoid", 0f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int mechoidIndex = Random.Range(0, positions.Length);
            Vector3 randomPosition = positions[mechoidIndex];
            Instantiate(mechoidPrefab[0], randomPosition, mechoidPrefab[0].transform.rotation);
        }
    }

    void spawnMechoid()
    {
        int mechoidIndex = Random.Range(0, positions.Length);
        Vector3 randomPosition = positions[mechoidIndex];
        Instantiate(mechoidPrefab[0], randomPosition, mechoidPrefab[0].transform.rotation);
    }
}
