/*
 * Dyson Smith
 * Oct 25 2021
 * Screen control
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rig;
    public float moveSpeed;
    public float jumpForce;
    public SpriteRenderer spr_comp;
    private void FixedUpdate()
    {
        //left right movment   
        float xInput = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(xInput * moveSpeed, rig.velocity.y);
    }
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        //sprit direction while moving
        if (rig.velocity.x > 0)
        {
            spr_comp.flipX = true;
        }
        else if (rig.velocity.x < 0)
        {
            spr_comp.flipX = false;
        }
        else
        {
            spr_comp.flipX = spr_comp.flipX;
        }

        // jumping
        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround())
        {
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    bool IsOnGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0, -0.1f, 0), Vector2.down, 0.2f);
        return hit.collider != null;
    }
}
