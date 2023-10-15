using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovementControl : MonoBehaviour
{
    float _backgroundPosition;
    const float _distance=10.24f;

    void Start()
    {
        _backgroundPosition = transform.position.y;
        FindObjectOfType<Planets>().PlacePlanet(_backgroundPosition);
    }

    


    private void FixedUpdate()
    {
        if (_backgroundPosition + _distance < Camera.main.transform.position.y)
        {
            SetBackgroundPosition();
        }
    }

    void SetBackgroundPosition()
    {
        _backgroundPosition += (_distance * 2);
        FindObjectOfType<Planets>().PlacePlanet(_backgroundPosition);
        Vector2 newPosition = new Vector2(0, _backgroundPosition);
        transform.position = newPosition;
    }
}
