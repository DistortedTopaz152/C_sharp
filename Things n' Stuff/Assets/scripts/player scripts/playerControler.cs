/*
 * Dyson Smith
 * Oct 21 2021
 * Controls player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerControler : MonoBehaviour
{
    public hudScript ui;
    public int playerlives =3;
    public int score;
    public Vector3 start_point;
    // Start is called before the first frame update
    void Start()
    {
        ui.set_text(playerlives, score);
        start_point = new Vector3(-7f, 0, 0);
        transform.position = start_point;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //takes player to game over screan
    public void gameOver()
    {
        if (playerlives >= 0)
        {
            transform.position = start_point;
            playerlives--;
            ui.set_text(playerlives, score);
        }
        else
        {
            SceneManager.LoadScene("gameover");
        }
    }

    // score changes
    public void add_to_score(int amount)
    {
        score += amount;
        ui.set_text(playerlives, score);
    }
}
