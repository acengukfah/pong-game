using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "WallVerticalLeft")
        {
            GetComponent<Transform>().position = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, Random.Range(-1, 1)) * 30;
        }
        if (collision.collider.name == "WallVerticalRight")
        {
            GetComponent<Transform>().position = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-1, Random.Range(-1, 1)) * 30;
        }
    }
}
