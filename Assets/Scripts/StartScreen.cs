using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public GameObject TheCreditsScreen;
    
    public void LoadScene(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    public void showCredits()
    {
        if (TheCreditsScreen) TheCreditsScreen.SetActive(true);
    }

    public void hideCredits()
    {
        if (TheCreditsScreen) TheCreditsScreen.SetActive(false);
    }

}