using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] mechoidPrefab;
    public GameObject[] wheelstingerPrefab;

    public float mechoidSpawnY = 92.5f;
    public float wheelstingerSpawnY = 23.5f;
    public float spawnZ = 1100f;

    public Vector3[] mechoidPositions;
    public Vector3[] wheelstingerPositions;

    void Start()
    {
        mechoidPositions = new Vector3[] {
            new Vector3(-115f, mechoidSpawnY, spawnZ),
            new Vector3(-15f, mechoidSpawnY, spawnZ),
            new Vector3(85f, mechoidSpawnY, spawnZ)
        };
        wheelstingerPositions = new Vector3[] {
            new Vector3(-63f, wheelstingerSpawnY, spawnZ),
            new Vector3(-23f, wheelstingerSpawnY, spawnZ),
            new Vector3(12f, wheelstingerSpawnY, spawnZ)
        };
        InvokeRepeating("spawnMechoid", 0f, 5f);
        //InvokeRepeating("spawnWheelstinger", 0f, 7.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnMechoid()
    {
        int mechoidIndex = Random.Range(0, mechoidPositions.Length);
        Vector3 randomPosition = mechoidPositions[mechoidIndex];
        Instantiate(mechoidPrefab[0], randomPosition, mechoidPrefab[0].transform.rotation);
    }

    void spawnWheelstinger()
    {
        int wheelstingerIndex = Random.Range(0, wheelstingerPositions.Length);
        Vector3 randomPosition = wheelstingerPositions[wheelstingerIndex];
        Instantiate(wheelstingerPrefab[0], randomPosition, wheelstingerPrefab[0].transform.rotation);
    }
}
