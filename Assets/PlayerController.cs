using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // [X] - Jump
    // [X] - Transition: Jump <=> Walk
    // [ ] - Handle MonsterCollision

    public float jumpFactor = 2f;
    public int maxHearts = 3;

    private bool isJumping = false;
    private bool isFalling = false;
    private Rigidbody2D rgbody;
    private Animator anim;

    private GameObject hearts;
    private int remaningHearts;

    void Start()
    {
        rgbody = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        hearts = GameObject.FindGameObjectWithTag("HeartsContainer");
        remaningHearts = maxHearts;
    }

    void Update() => performMovementActions();

    void OnCollisionEnter2D (Collision2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Ground":
                onGroundCollision(collision);
                break;
            case "Monster":
                onMonsterCollision(collision);
                break;
        }
    }

    void onGroundCollision(Collision2D collision = null) { isJumping = false; isFalling = false; }

    //void onMonsterCollision(Collision2D collision = null) => Debug.Log("Monster Collision");
    void onMonsterCollision(Collision2D collision = null) {
        remaningHearts--;
        hearts.SendMessage("DecreaseHeart", 1);

        if (remaningHearts <= 0) {
            Time.timeScale = 0;
        }
    }

    private void performMovementActions() => performJumps();

    private void performJumps()
    {
        float input = Input.GetAxis("Vertical");

        if (input > 0 && !isJumping && !isFalling)
            rgbody.velocity = Vector2.up * jumpFactor;

        if (rgbody.velocity.y > 0)
        {
            isJumping = true;
            isFalling = false;
        }
        else if (rgbody.velocity.y < 0)
        {
            isJumping = false;
            isFalling = true;
        }
        else
        {
            isJumping = false;
            isFalling = false;
        }

        anim.SetBool("isJumping", isJumping);
        anim.SetBool("isFalling", isFalling);
    }
}