using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject playScreen;
    public GameObject scoreScreen;
    public GameObject settingsScreen;
    public GameObject exitScreen;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void openPlay()
    {
        playScreen.SetActive(true);
    }

    public void closePlay()
    {
        playScreen.SetActive(false);
    }

    public void openScores()
    {
        scoreScreen.SetActive(true);
    }

    public void closeScores()
    {
        scoreScreen.SetActive(false);
    }

    public void openSettings()
    {
        settingsScreen.SetActive(true);
    }

    public void closeSettings()
    {
        settingsScreen.SetActive(false);
    }

    public void openExit()
    {
        exitScreen.SetActive(true);
    }

    public void closeExit()
    {
        exitScreen.SetActive(false);
    }
}
