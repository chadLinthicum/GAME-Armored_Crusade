using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyButtonScript : MonoBehaviour
{
    public void btn_Home(int sceneID)
    {
        Score.playerScore = 0;
        SpawnManager.wave2 = false;
        SpawnManager.wave3 = false;
        SpawnManager.wave4 = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    public void btn_Retry(int sceneID)
    {
        Score.playerScore = 0;
        SpawnManager.wave2 = false;
        SpawnManager.wave3 = false;
        SpawnManager.wave4 = false;
        SpawnManager.boss = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}