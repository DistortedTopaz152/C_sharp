/*
 * Dyson Smith
 * Oct 21 2021
 * hit the goual
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midpoint : MonoBehaviour
{
    public Vector3 currentpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerControler>().start_point = currentpos;
        }
    }
}
