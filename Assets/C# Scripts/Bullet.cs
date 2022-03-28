using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject player;
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
            Destroy(collision.gameObject);
            Destroy(gameObject);
            GameObject player = GameObject.Find("Player");
            player.GetComponent<PlayerEnemyInteractions>().score += 100;
            player.GetComponent<PlayerEnemyInteractions>().scoreLabel.text = player.GetComponent<PlayerEnemyInteractions>().score.ToString();
        }
        Destroy(gameObject);
    }
}
