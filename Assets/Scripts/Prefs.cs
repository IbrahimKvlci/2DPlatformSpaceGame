using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Prefs
{
    public static string _difficulty="difficulty";
    public static string _easyScore = "easyScore";
    public static string _mediumScore = "mediumScore";
    public static string _hardScore = "hardScore";
    public static string _easyGold = "easyGold";
    public static string _mediumGold = "mediumGold";
    public static string _hardGold = "hardGold";
    public static string _musicOn = "musicOn";

    public static void SetDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(Prefs._difficulty, difficulty);
    }

    public static void SetDifficultyScore(string key,int difficultyScore)
    {
        PlayerPrefs.SetInt(key, difficultyScore);
    }

    public static void SetDifficultyGold(string key,int difficultyGold)
    {
        PlayerPrefs.SetInt(key, difficultyGold);
    }

    public static void SetMusicOn(int musicOn)
    {
        PlayerPrefs.SetInt(Prefs._musicOn, musicOn);
    }

    public static int GetDifficulty()
    {
        return PlayerPrefs.GetInt(Prefs._difficulty);
    }
    public static int GetDifficultyScore(string key)
    {
        return PlayerPrefs.GetInt(key);
    }
    public static int GetDifficultyGold(string key)
    {
        return PlayerPrefs.GetInt(key);
    }
    public static int GetMusicOn()
    {
        return PlayerPrefs.GetInt(Prefs._musicOn);
    }

    public static bool IsThereDifficultyPref()
    {
        return PlayerPrefs.HasKey(_difficulty);
    }
    public static bool IsThereMusicOnPref()
    {
        return PlayerPrefs.HasKey(_musicOn);
    }

}
