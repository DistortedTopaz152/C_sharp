/*
 * Dyson Smith
 * Oct 21 2021
 * hit the goual
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hudScript : MonoBehaviour
{
    public TextMeshProUGUI score_txt;
    public TextMeshProUGUI lives_txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void set_text(int lives, int score)
    {
        score_txt.text = "Score: " + score.ToString();
        lives_txt.text = "lives: " + lives.ToString();
    }
}
