using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D player;
    public Camera camera;
    Vector2 movementVector;
    Vector2 mouseVector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");

        mouseVector = camera.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        player.MovePosition(player.position + movementVector * movementSpeed * Time.fixedDeltaTime);

        Vector2 mouseDirection = mouseVector - player.position;
        float angle = Mathf.Atan2(mouseDirection.y, mouseDirection.x) * Mathf.Rad2Deg + 10F;
        player.rotation = angle;
    }
}
