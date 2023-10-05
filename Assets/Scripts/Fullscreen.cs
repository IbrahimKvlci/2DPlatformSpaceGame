using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen : MonoBehaviour
{
    
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Vector2 tempScale = transform.localScale;

        float spriteWidth = spriteRenderer.size.x;
        float screenHeight = Camera.main.orthographicSize * 2f;
        float screenWidth = screenHeight/Screen.height*Screen.width;
        tempScale.x = screenWidth / spriteWidth;
        transform.localScale = tempScale;

        Debug.Log($"Sprite Width: {spriteWidth}, Screen Height: {screenHeight}, Screen Width: {screenWidth}, {Screen.height}, {Screen.width}, {screenHeight/Screen.height * Screen.width}");
    }

    
}
