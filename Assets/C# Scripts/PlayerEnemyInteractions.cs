using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerEnemyInteractions : MonoBehaviour
{
    public int health = 100;
    public TMP_Text healthText;
    public Rigidbody2D player;

    public GameObject playerGO;
    public GameObject battery;
    public GameObject darkness;
    public GameObject endgameNotification;

    public int score = 0;
    public TMP_Text scoreLabel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 10;
            if (health <= 0)
            {
                endgame();
            }
            else
            {
                healthText.text = health.ToString();
            }

            for (int i = 0 ; i < 10; i++)
            {
                Vector2 knockbackDirection = (transform.position - collision.gameObject.transform.position);
                player.AddForce(knockbackDirection * 500F);
            }
        }
        
        if (collision.gameObject.tag == "Power")
        {
            battery.GetComponent<Flashlight>().battery = 110;
            battery.GetComponent<Flashlight>().batteryLabel.text = "100%"; 
            darkness.SetActive(false);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Ammo")
        {
            playerGO.GetComponent<PlayerShooting>().ammo = 6;
            playerGO.GetComponent<PlayerShooting>().ammoAmount.text = "6/6";
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Health")
        {
            health = 100;
            healthText.text = health.ToString();
            Destroy(collision.gameObject);
        }
    }

    private void endgame()
    {
        endgameNotification.SetActive(true);
        Time.timeScale = 0;
        Destroy(playerGO);
    }
}
