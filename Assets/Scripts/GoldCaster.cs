using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCaster : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Foot")
        {
            GetComponentInParent<Gold>().OffGold();
            FindObjectOfType<Score>().EarnGold();
        }
    }
}
