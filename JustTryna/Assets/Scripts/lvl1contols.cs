using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class playerMove : MonoBehaviour
{

    //visible from editor float variable for Player's moving speed (left/right)
    public float speed;
    //variable for Player's Rigibody2D component
    Rigidbody2D rb;
    //float variable for Horizontal axis value from Input Manager
    float x;
    //variable for calculated vector, which will be used for velocity changes
    Vector2 move;

    //this function will be executed once as script was enabled
    void Start()
    {
        //reference to Rigidbody2D Component
        rb = GetComponent<Rigidbody2D>();
        Cursor.visible = true;
    }

    //this function will be executed every fixed time step (default is 0.02)
    void FixedUpdate()
    {
        //set variable x to value, which we can get from Input Manager's Horizontal axis
        x = Input.GetAxis("Horizontal");
        //calculate moving vector (left/right) and y value will stay unchanged
        move = new Vector2(x * speed, rb.velocity.y);
        //change Player's velocity (move it left/right or stop)
        rb.velocity = move;
    }
}

