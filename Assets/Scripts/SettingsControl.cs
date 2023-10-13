using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsControl : MonoBehaviour
{
    public Button _easyButton, _mediumButton, _hardButton;

    private void Start()
    {
        switch (Prefs.GetDifficulty())
        {
            case 0:
                _easyButton.interactable = false;
                _mediumButton.interactable = true;
                _hardButton.interactable = true;
                break;
            case 1:
                _easyButton.interactable = true;
                _mediumButton.interactable = false;
                _hardButton.interactable = true;
                break;
            case 2:
                _easyButton.interactable = true;
                _mediumButton.interactable = true;
                _hardButton.interactable = false;
                break;

            default:
                break;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }


    public void SetDifficulty(int difficulty)
    {
        Prefs.SetDifficulty(difficulty);
        switch (difficulty)
        {
            case 0:
                _easyButton.interactable = false;
                _mediumButton.interactable = true;
                _hardButton.interactable = true;
                break;
            case 1:
                _easyButton.interactable = true;
                _mediumButton.interactable = false;
                _hardButton.interactable = true;
                break;
            case 2:
                _easyButton.interactable = true;
                _mediumButton.interactable = true;
                _hardButton.interactable = false;
                break;

            default:
                break;
        }
    }
}
