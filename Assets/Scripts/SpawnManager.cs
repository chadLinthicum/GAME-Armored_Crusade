using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] mechoidPrefab;

    public float spawnY = 100f;
    public float spawnZ = 872f;

    public Vector3[] positions;

    void Start()
    {
        positions = new Vector3[] {
            new Vector3(-175.4f, spawnY, spawnZ),
            new Vector3(-27.7f, spawnY, spawnZ),
            new Vector3(125.35f, spawnY, spawnZ)
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
