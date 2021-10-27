/*
 * Dyson Smith
 * Oct 27 2021
 * Screen control
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidetoside : MonoBehaviour
{
    public float movespeed = 15;
    public Vector3 targetpos;
    private Vector3 startpos;
    public SpriteRenderer spr_comp;

    private bool movingToTarget;


    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        movingToTarget = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (movingToTarget == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetpos, movespeed * Time.deltaTime);
            if (transform.position == targetpos)
            {
                movingToTarget = false;
                spr_comp.flipX = true;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startpos, movespeed * Time.deltaTime);
            if (transform.position == startpos)
            {
                movingToTarget = true;
                spr_comp.flipX = false;
            }
        }

    }
}

