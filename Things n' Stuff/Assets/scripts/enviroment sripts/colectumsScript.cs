/*
 * Dyson Smith
 * Oct 19 2021
 * colecting thangs
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colectumsScript : MonoBehaviour
{
    public int value = 100;
    // collition with colectems
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerControler>().add_to_score(value);
            Destroy(gameObject);
        }
    }
}
