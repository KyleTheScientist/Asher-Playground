using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController2D controller;
    public float forceWhenFalling;
    public Rigidbody2D rb2D;
    // Update is called once per frame
    void Update()
    {
        float leftRight = Input.GetAxis("Horizontal");
        controller.Move(leftRight, false, Input.GetKey("space"));
        //rb2D.AddForce(new Vector2(leftRight * moveSpeed, 0));

        //float xVelAfterFriction = Mathf.Lerp(rb2D.velocity.x, 0, friction);
        //rb2D.velocity = new Vector2(xVelAfterFriction, rb2D.velocity.y);

        //if (grounded && Input.GetKeyDown("space"))
        //{
        //    rb2D.AddForce(new Vector2(0, jumpForce));
        //}

        if (rb2D.velocity.y < 0)
        {
            rb2D.AddForce(new Vector2(0, forceWhenFalling));
        }
    }
}

