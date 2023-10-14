using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyPlatform : Platform
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Foot")
        {
            FindObjectOfType<GameControl>().GameOver();
        }
    }
}
