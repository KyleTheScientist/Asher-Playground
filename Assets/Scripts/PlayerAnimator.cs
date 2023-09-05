using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Player player;
    Animator animator;
    SpriteRenderer sprite;
    bool flipped;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        //sprite.flipX = !player.controller.FacingRight;
        animator.SetBool("onGround", player.controller.Grounded);
        animator.SetBool("isMoving", player.rb2D.velocity.magnitude > .01);
        animator.SetFloat("yVel", player.rb2D.velocity.y);
    }
}
