using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D enemy;
    public float speed = 1.5F;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D enemy = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 playerDirection = player.position - transform.position;
        float angle = Mathf.Atan2(playerDirection.y, playerDirection.x) * Mathf.Rad2Deg;
        enemy.rotation = angle;

        enemy.MovePosition((Vector2)transform.position + (Vector2)playerDirection * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Power" || collision.gameObject.tag == "Ammo" || collision.gameObject.tag == "Health" || collision.gameObject.tag == "Trap")
        {
            Collider2D collisioN = gameObject.GetComponent<Collider2D>();
            Physics2D.IgnoreCollision(collision.collider, collisioN);
        }
    }
}
