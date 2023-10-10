using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _scoreText;

    int _score;

    void Start()
    {
        
    }

    
    void Update()
    {
        _score = (int)Camera.main.transform.position.y;
        _scoreText.text = $"SCORE: {_score}";
    }
}
