using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //tells the player they've bean hit
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<playerControler>().gameOver();
        }
    }
}
