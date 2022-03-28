using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (player != null)
        {
            position = new Vector2(player.transform.position.x, player.transform.position.y);
            transform.position = Vector2.Lerp(transform.position, position, speed);
        }
    }
}
