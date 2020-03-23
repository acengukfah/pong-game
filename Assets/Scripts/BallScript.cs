using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public int speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 1) * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1, 1) * speed;
    }
}