using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneControler : MonoBehaviour
{
    public void onClick(string level)
    {
        SceneManager.LoadScene(level);
    }
}
