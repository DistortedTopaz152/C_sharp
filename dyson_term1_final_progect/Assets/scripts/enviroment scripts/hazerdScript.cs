/*
 * Dyson Smith
 * Oct 27 2021
 * Screen control
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazerdScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerControler>().gameOver();
        }
    }
}
