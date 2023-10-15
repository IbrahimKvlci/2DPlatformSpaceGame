using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    [SerializeField] Sprite[] _musicIcons;
    [SerializeField] Button _musicButton;


    void Start()
    {
        
        if (!Prefs.IsThereDifficultyPref())
        {
            Prefs.SetDifficulty(0);
        }
        if (!Prefs.IsThereMusicOnPref())
        {
            Prefs.SetMusicOn(1);
        }
        CheckMusicSettings();
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
        if (Prefs.GetMusicOn()==1)
        {
            Prefs.SetMusicOn(0);
            MusicControl._instance.PlayMusic(false);
            _musicButton.image.sprite = _musicIcons[0];
        }
        else
        {
            Prefs.SetMusicOn(1);
            MusicControl._instance.PlayMusic(true);
            _musicButton.image.sprite = _musicIcons[1];
        }
    }

    void CheckMusicSettings()
    {
        if (Prefs.GetMusicOn() == 1)
        {
            MusicControl._instance.PlayMusic(true);
            _musicButton.image.sprite = _musicIcons[1];
        }
        else
        {
            MusicControl._instance.PlayMusic(false);
            _musicButton.image.sprite = _musicIcons[0];
        }
    }
}
