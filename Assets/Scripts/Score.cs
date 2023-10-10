using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _scoreText;

    [SerializeField]
    TextMeshProUGUI _goldText;

    int _score;
    int _gold;

    void Start()
    {
        _goldText.text = $"{_gold}";
    }

    
    void Update()
    {
        _score = (int)Camera.main.transform.position.y;
        _scoreText.text = $"SCORE: {_score}";
    }

    public void EarnGold()
    {
        _gold++;
        _goldText.text = $"{_gold}";
    }
}
