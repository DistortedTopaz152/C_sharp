/*
 * Dyson Smith
 * Oct 27 2021
 * Screen control
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public bool finalLevel;
    public string nextSceneName;
    public int nextSceneindex;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (finalLevel)
            {
                SceneManager.LoadScene(0);
            }
            else if (!finalLevel)
            {
                SceneManager.LoadScene(nextSceneName);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (finalLevel)
            {
                SceneManager.LoadScene(0);
            }
            else if (!finalLevel)
            {
                SceneManager.LoadScene(nextSceneName);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}