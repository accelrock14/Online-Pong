using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    [SerializeField] private Vector2 direction;

    private void FixedUpdate()
    {
        float direction = Input.GetAxis("Vertical"); // Get vertical input

        Vector2 movement = new Vector2(0f, direction) * this.speed;
        rb.velocity = movement;
    }
}
