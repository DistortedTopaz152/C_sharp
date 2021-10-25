/*
  Dyson Smith
  Oct 5 2021
  Player movement
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    // veriables so that we can see them in unity and for movement physics
    public Rigidbody2D rig;
    public float move_speed;
    public float jump_force;
    public SpriteRenderer spr_comp;
    // Update for things not tied to fps
    private void FixedUpdate()
    {
        // movement left/right
        float xinput = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(xinput*move_speed,rig.velocity.y);
    }
    // Update is called once per frame
    void Update()
    {
        // sprite derection
        if (rig.velocity.x > 0)
        {
            spr_comp.flipX = false;
        }
        else if (rig.velocity.x <0)
        {
            spr_comp.flipX = true;
        }
        else
        {
            spr_comp.flipX = spr_comp.flipX;
        }
        // jump
        if (Input.GetKeyDown(KeyCode.Space) && Is_on_ground())
        {
            rig.AddForce(Vector2.up * jump_force, ForceMode2D.Impulse);
        }
    }
    //checking if the player is on the ground
    bool Is_on_ground() 
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position+new Vector3(0,-0.1f,0), Vector2.down, 0.2f);
        return hit.collider != null;
    }
}
