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
    int _bestScore;
    int _bestGold;

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
        switch (Prefs.GetDifficulty())
        {
            case 0:
                _bestScore = Prefs.GetDifficultyScore(Prefs._easyScore);
                _bestGold = Prefs.GetDifficultyGold(Prefs._easyGold);
                if (_score > _bestScore)
                {
                    Prefs.SetDifficultyScore(Prefs._easyScore, _score);
                }
                if (_gold > _bestGold)
                {
                    Prefs.SetDifficultyGold(Prefs._easyGold, _gold);
                }
                break;
            case 1:
                _bestScore = Prefs.GetDifficultyScore(Prefs._mediumScore);
                _bestGold = Prefs.GetDifficultyGold(Prefs._mediumGold);
                if (_score > _bestScore)
                {
                    Prefs.SetDifficultyScore(Prefs._mediumScore, _score);
                }
                if (_gold > _bestGold)
                {
                    Prefs.SetDifficultyGold(Prefs._mediumGold, _gold);
                }
                break;
            case 2:
                _bestScore = Prefs.GetDifficultyScore(Prefs._hardScore);
                _bestGold = Prefs.GetDifficultyGold(Prefs._hardGold);
                if (_score > _bestScore)
                {
                    Prefs.SetDifficultyScore(Prefs._hardScore, _score);
                }
                if (_gold > _bestGold)
                {
                    Prefs.SetDifficultyGold(Prefs._hardGold, _gold);
                }
                break;
            default:
                break;
        }

        _gameOver = true;
        _gameOverScoreText.text = $"Score: {_score}";
        _gameOverGoldText.text =$"X{ _gold}";
        
    }
}
