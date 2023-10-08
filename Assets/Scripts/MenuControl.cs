using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    [SerializeField] Sprite[] _musicIcons;
    [SerializeField] Button _musicButton;

    bool _musicOn;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Score()
    {
        SceneManager.LoadScene("Score");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Music()
    {
        if (_musicOn)
        {
            _musicOn = false;
            _musicButton.image.sprite = _musicIcons[0];
        }
        else
        {
            _musicOn = true;
            _musicButton.image.sprite = _musicIcons[1];
        }
    }
}
