using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] mechoidPrefab;
    public GameObject[] wheelstingerPrefab;

    public float mechoidSpawnY = 92.5f;
    public float wheelstingerSpawnY = 23.5f;
    public float spawnZ = 1100f;

    public Vector3[] mechoidPositions;
    public Vector3[] wheelstingerPositions;

    public static bool wave2 = false;
    public static bool wave3 = false;

    public TextMeshProUGUI lbl_boss;
    public TextMeshProUGUI lbl_ready;
    public TextMeshProUGUI lbl_wave2;
    public TextMeshProUGUI lbl_wave3;

    void Start()
    {
        lbl_ready.gameObject.SetActive(true);
        StartCoroutine(StopTimeForFiveSeconds());
        lbl_wave2.gameObject.SetActive(false);
        lbl_wave3.gameObject.SetActive(false);
        lbl_boss.gameObject.SetActive(false);

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
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.playerScore >= 50 && !wave2)
        {
            lbl_wave2.gameObject.SetActive(true);
            StartCoroutine(StopTimeForTwoSeconds());
            InvokeRepeating("spawnWheelstinger", 0f, 7.5f);
            wave2 = !wave2;

        }
        if (Score.playerScore >= 150 && !wave3)
        {
            lbl_wave3.gameObject.SetActive(true);
            StartCoroutine(StopTimeForTwoSeconds());
            InvokeRepeating("spawnBeetlebomber", 0f, 7.5f);
            wave3 = !wave3;
        }
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

    private IEnumerator StopTimeForTwoSeconds()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(2f);
        Time.timeScale = 1f;
        lbl_ready.gameObject.SetActive(false);
        lbl_wave2.gameObject.SetActive(false);
        lbl_wave3.gameObject.SetActive(false);
        lbl_boss.gameObject.SetActive(false);
    }
    private IEnumerator StopTimeForFiveSeconds()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(5f);
        Time.timeScale = 1f;
        lbl_ready.gameObject.SetActive(false);
    }
}
