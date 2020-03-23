using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    public int speed = 20;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start () {
        rb.velocity = new Vector2 (1, 1) * speed;
    }

    private void OnTriggerEnter2D (Collider2D collision) {
        rb.velocity = new Vector2 (1, 1) * speed;
    }
}