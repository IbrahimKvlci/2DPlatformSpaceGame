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

    [SerializeField]
    TextMeshProUGUI _gameOverScoreText;

    [SerializeField]
    TextMeshProUGUI _gameOverGoldText;

    int _score;
    int _gold;

    bool _gameOver;

    void Start()
    {

        _goldText.text = $"{_gold}";
    }

    
    void Update()
    {
        if (!_gameOver)
        {
            _score = (int)Camera.main.transform.position.y;
            _scoreText.text = $"SCORE: {_score}";
        }
        
    }

    public void EarnGold()
    {
        _gold++;
        _goldText.text = $"{_gold}";
    }

    public void GameOver()
    {
        _gameOver = true;
        _gameOverScoreText.text = $"Score: {_score}";
        _gameOverGoldText.text =$"X{ _gold}";
        
    }
}
