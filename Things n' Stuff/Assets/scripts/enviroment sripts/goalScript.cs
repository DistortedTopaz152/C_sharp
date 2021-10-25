/*
 * Dyson Smith
 * Oct 21 2021
 * hit the goual
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalScript : MonoBehaviour
{
    public bool final_level;
    public string next_scene_name;
    public int next_scene_index;
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    // colistion detection
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if (final_level == true)
            {
                SceneManager.LoadScene(0);
            }
            else if (final_level == false)
            {
                SceneManager.LoadScene(next_scene_name);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    // over lap detection
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (final_level == true)
            {
                SceneManager.LoadScene(0);
            }
            else if (final_level == false)
            {
                SceneManager.LoadScene(next_scene_name);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
