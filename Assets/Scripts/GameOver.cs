using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyButtonScript : MonoBehaviour
{
    public void btn_Home(int sceneID)
    {
<<<<<<< HEAD
        Score.playerScore = 0;
        SpawnManager.wave2 = false;
        SpawnManager.wave3 = false;
        SpawnManager.wave4 = false;
=======
>>>>>>> 0ebba89f23040ab6b6b3d1e8b52ffe6d6b5ac84e
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    public void btn_Retry(int sceneID)
    {
        Score.playerScore = 0;
<<<<<<< HEAD
        SpawnManager.wave2 = false;
        SpawnManager.wave3 = false;
        SpawnManager.wave4 = false;
        SpawnManager.boss = false;
=======
>>>>>>> 0ebba89f23040ab6b6b3d1e8b52ffe6d6b5ac84e
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}