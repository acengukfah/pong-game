using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float mapWidth = 10f;
    public float playerForce = 50;
    private Vector2 velocity;
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
    void FixedUpdate()
    {
        //player 1
        if (Input.GetKey(KeyCode.W))
        {
            velocity = new Vector2(0f, playerForce);
            Vector2 newPosition1 = rb1.position + velocity * Time.fixedDeltaTime;
            newPosition1.y = Mathf.Clamp(newPosition1.y, -mapWidth, mapWidth);

            rb1.MovePosition(newPosition1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity = new Vector2(0f, -playerForce);
            Vector2 newPosition1 = rb1.position + velocity * Time.fixedDeltaTime;
            newPosition1.y = Mathf.Clamp(newPosition1.y, -mapWidth, mapWidth);

            rb1.MovePosition(newPosition1);
        }
        //player 2
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity = new Vector2(0f, playerForce);
            Vector2 newPosition1 = rb2.position + velocity * Time.fixedDeltaTime;
            newPosition1.y = Mathf.Clamp(newPosition1.y, -mapWidth, mapWidth);

            rb2.MovePosition(newPosition1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity = new Vector2(0f, -playerForce);
            Vector2 newPosition1 = rb2.position + velocity * Time.fixedDeltaTime;
            newPosition1.y = Mathf.Clamp(newPosition1.y, -mapWidth, mapWidth);

            rb2.MovePosition(newPosition1);
        }
    }
}
