using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInScreen : MonoBehaviour
{

    void Update()
    {
        if (transform.position.x < -ScreenCalculator._instance.Width)
        {
            Vector2 temp = transform.position;
            temp.x = -ScreenCalculator._instance.Width;
            transform.position = temp;
        }
        if (transform.position.x > ScreenCalculator._instance.Width)
        {
            Vector2 temp = transform.position;
            temp.x = ScreenCalculator._instance.Width;
            transform.position = temp;
        }

    }
}
