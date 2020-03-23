using UnityEngine;

public class Raket : MonoBehaviour
{
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
    public float playerForce = 500;
    private bool upKeys1 = false;
    private bool downKeys1 = false;
    private bool leftKeys1 = false;
    private bool rightKeys1 = false;
    private bool upKeys2 = false;
    private bool downKeys2 = false;
    private bool leftKeys2 = false;
    private bool rightKeys2 = false;
    private Vector2 velocity;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Player 2
        if (Input.GetKey(KeyCode.W))
        {
            upKeys2 = true;
        }
        else
        {
            upKeys2 = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            downKeys2 = true;
        }
        else
        {
            downKeys2= false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            leftKeys2 = true;
        }
        else
        {
            leftKeys2 = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rightKeys2 = true;
        }
        else
        {
            rightKeys2 = false;
        }

        if (downKeys2)
        {
            velocity = new Vector2(0f, -playerForce);
            rb2.MovePosition(rb2.position + velocity * Time.fixedDeltaTime);

        }

        if (leftKeys2)
        {
            velocity = new Vector2(-playerForce, 0f);
            rb2.MovePosition(rb2.position + velocity * Time.fixedDeltaTime);

        }

        if (rightKeys2)
        {
            velocity = new Vector2(playerForce, 0f);
            rb2.MovePosition(rb2.position + velocity * Time.fixedDeltaTime);

        }

        if (upKeys2)
        {
            velocity = new Vector2(0f, playerForce);
            rb2.MovePosition(rb2.position + velocity * Time.fixedDeltaTime);
        }


        //Player 1
        if (Input.GetKey(KeyCode.UpArrow))
        {
            upKeys1 = true;
        }
        else
        {
            upKeys1 = false;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            downKeys1 = true;
        }
        else
        {
            downKeys1 = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftKeys1 = true;
        }
        else
        {
            leftKeys1 = false;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightKeys1 = true;
        }
        else
        {
            rightKeys1 = false;
        }

        if (downKeys1)
        {
            velocity = new Vector2(0f, -playerForce);
            rb1.MovePosition(rb1.position + velocity * Time.fixedDeltaTime);

        }

        if (leftKeys1)
        {
            velocity = new Vector2(-playerForce, 0f);
            rb1.MovePosition(rb1.position + velocity * Time.fixedDeltaTime);
        }

        if (rightKeys1)
        {
            velocity = new Vector2(playerForce, 0f);
            rb1.MovePosition(rb1.position + velocity * Time.fixedDeltaTime);

        }

        if (upKeys1)
        {
            velocity = new Vector2(0f, playerForce);
            rb1.MovePosition(rb1.position + velocity * Time.fixedDeltaTime);
        }
    }
}
