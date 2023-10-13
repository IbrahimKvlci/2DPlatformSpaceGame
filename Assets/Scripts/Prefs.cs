using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Prefs
{
    public static string _difficulty="difficulty";
    public static string _difficultyScore = "difficultyScore";
    public static string _difficultyGold = "difficultyGold";
    public static string _musicOn = "musicOn";

    public static void SetDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(Prefs._difficulty, difficulty);
    }

    public static void SetDifficultyScore(int difficultyScore)
    {
        PlayerPrefs.SetInt(Prefs._difficultyScore, difficultyScore);
    }

    public static void SetDifficultyGold(int difficultyGold)
    {
        PlayerPrefs.SetInt(Prefs._difficultyGold, difficultyGold);
    }

    public static void SetMusicOn(int musicOn)
    {
        PlayerPrefs.SetInt(Prefs._musicOn, musicOn);
    }

    public static int GetDifficulty()
    {
        return PlayerPrefs.GetInt(Prefs._difficulty);
    }
    public static int GetDifficultyScore()
    {
        return PlayerPrefs.GetInt(Prefs._difficultyScore);
    }
    public static int GetDifficultyGold()
    {
        return PlayerPrefs.GetInt(Prefs._difficultyGold);
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
