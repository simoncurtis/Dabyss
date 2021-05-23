using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Vector2 movement;

    Rigidbody2D rb2d;

    public float speed = 5f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);
    }
}
