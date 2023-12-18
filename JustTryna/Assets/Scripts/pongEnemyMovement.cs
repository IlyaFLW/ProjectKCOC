using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongEnemyMovement : MonoBehaviour
{


    public float speed = 10.0f;
    public float boundY = 2.25f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(0.0f, -1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        if (rb2d.transform.position.y == boundY)
        {
            rb2d.velocity = new Vector2(0.0f, -speed);
        }
        if (rb2d.transform.position.y == -boundY)
        {
            rb2d.velocity = new Vector2(0.0f, speed);
        }

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
            vel.y = -speed;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
            vel.y = -speed;
        }
        transform.position = pos;
    }
}
