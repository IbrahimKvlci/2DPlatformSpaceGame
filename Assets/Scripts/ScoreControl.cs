using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreControl : MonoBehaviour
{
    public TextMeshProUGUI _easyScore,_easyGold,_mediumScore,_mediumGold,_hardScore, _hardGold;

    private void Start()
    {
        _easyScore.text = $"Score: {Prefs.GetDifficultyScore(Prefs._easyScore)}";
        _easyGold.text = $"X {Prefs.GetDifficultyGold(Prefs._easyGold)}";
        _mediumScore.text = $"Score: {Prefs.GetDifficultyScore(Prefs._mediumScore)}";
        _mediumGold.text = $"X {Prefs.GetDifficultyGold(Prefs._mediumGold)}";
        _hardScore.text = $"Score: {Prefs.GetDifficultyScore(Prefs._hardScore)}";
        _hardGold.text = $"X {Prefs.GetDifficultyGold(Prefs._hardGold)}";

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
