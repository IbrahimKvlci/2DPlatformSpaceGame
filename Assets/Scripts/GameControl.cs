using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject _gameOverPanel;
    public GameObject _joystick;
    public GameObject _jumpButton;
    public GameObject _sign;
    public GameObject _slider;


    void Start()
    {
        _gameOverPanel.SetActive(false);
        TurnOnUI();
    }


    public void GameOver()
    {
        FindObjectOfType<SoundControl>().PlayGameOverSound();
        _gameOverPanel.SetActive(true);
        FindObjectOfType<Score>().GameOver();
        FindObjectOfType<PlayerMovement>().GameOver();
        TurnOffUI();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    void TurnOnUI()
    {
        _joystick.SetActive(true);
        _jumpButton.SetActive(true);
        _sign.SetActive(true);
        _slider.SetActive(true);

    }

    void TurnOffUI()
    {
        _joystick.SetActive(false);
        _jumpButton.SetActive(false);
        _sign.SetActive(false);
        _slider.SetActive(false);
        
    }
}
