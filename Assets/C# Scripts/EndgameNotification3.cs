using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndgameNotification3 : MonoBehaviour
{
    public string pandemic, mainmenu;

    public int score;
    public TMP_Text scoreLabel;

    public GameObject player;


    GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }

        score = player.GetComponent<PlayerEnemyInteractions>().score;
        scoreLabel.text = score.ToString();

        int highScore1 = PlayerPrefs.GetInt("highScore1");
        int highScore2 = PlayerPrefs.GetInt("highScore2");
        int highScore3 = PlayerPrefs.GetInt("highScore3");

        if (score > highScore1)
        {
            PlayerPrefs.SetInt("highScore3", highScore2);
            PlayerPrefs.SetInt("highScore2", highScore1);
            PlayerPrefs.SetInt("highScore1", score);
        }
        else if (score > highScore2)
        {
            PlayerPrefs.SetInt("highScore3", highScore2);
            PlayerPrefs.SetInt("highScore2", score);
        }
        else if (score > highScore3)
        {
            PlayerPrefs.SetInt("highScore3", score);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(pandemic);
    }

    public void mainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(mainmenu);
    }
}
