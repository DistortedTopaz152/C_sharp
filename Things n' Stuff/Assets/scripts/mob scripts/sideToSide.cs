using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideToSide : MonoBehaviour
{
    // establishing variables
    public float movespeed = 3;
    public Vector3 targetpos;
    private Vector3 startpos;

    private bool moving_to_target;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        moving_to_target = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving_to_target == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetpos, movespeed*Time.deltaTime);
            if (transform.position == targetpos)
            {
                moving_to_target = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startpos, movespeed * Time.deltaTime);
            if (transform.position == startpos)
            {
                moving_to_target = true;
            }
        }
    }
}
