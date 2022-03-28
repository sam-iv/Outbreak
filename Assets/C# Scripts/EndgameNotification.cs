using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndgameNotification : MonoBehaviour
{
    public string endemic, mainmenu;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(endemic);
    }

    public void mainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(mainmenu);
    }
}
