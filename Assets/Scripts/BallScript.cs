using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public int speed = 20;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(-1, -1) * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        rb.velocity = new Vector2(-1, -1) * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "WallVerticalLeft" || collision.collider.name == "WallVerticalRight")
        {
            StartCoroutine(jeda());
        }
    }
    IEnumerator jeda()
    {
        rb.velocity = Vector2.zero;
        rb.GetComponent<Transform>().position = Vector2.zero;
        yield return new WaitForSeconds(1);
        rb.velocity = new Vector2(-1, -1) * speed;
    }
}