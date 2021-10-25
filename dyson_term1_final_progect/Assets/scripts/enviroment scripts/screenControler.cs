/*
 * Dyson Smith
 * Oct 25 2021
 * Screen control
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenControler : MonoBehaviour
{
    public void on_click(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void on_click_quit()
    {
        Application.Quit();
    }
}
