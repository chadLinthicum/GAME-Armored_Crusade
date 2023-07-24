using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] mechoidPrefab;

    //public Vector3 left = new Vector3(-175.4f, 106.3f, 872);
    //public Vector3 center = new Vector3(-27.7f, 106.3f, 872);
    //public Vector3 right = new Vector3(125.35f, 106.3f, 872);

    public Vector3[] positions = new Vector3[] {
        new Vector3(-175.4f, 106.3f, 872),
        new Vector3(-27.7f, 106.3f, 872),
        new Vector3(125.35f, 106.3f, 872)
    };

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int mechoidIndex = Random.Range(0, positions.Length);
            Vector3 randomPosition = positions[mechoidIndex];

            //left, center, right need to be random
            Instantiate(mechoidPrefab[0], randomPosition, mechoidPrefab[0].transform.rotation);
        }
    }
}
