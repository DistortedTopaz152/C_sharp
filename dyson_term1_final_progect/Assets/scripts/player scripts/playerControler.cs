/*
 * Dyson Smith
 * Oct 25 2021
 * Screen control
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerControler : MonoBehaviour
{
    public int playerLives = 3;
    public int score;
    public Vector3 startPoint;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = new Vector3(-7, -2, 0);
        transform.position = startPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameOver()
    {

        if (playerLives >= 0)
        {
            transform.position = startPoint;
            playerLives--;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
    public void addToScore(int amount)
    {
        score += amount;
    }
}
