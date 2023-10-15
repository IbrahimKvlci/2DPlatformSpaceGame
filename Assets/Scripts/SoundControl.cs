using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioClip _jump;
    public AudioClip _gold;
    public AudioClip _gameOver;

    AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayJumpSound()
    {
        _audioSource.clip = _jump;
        _audioSource.Play();
    }

    public void PlayGoldSound()
    {
        _audioSource.clip = _gold;
        _audioSource.Play();
    }
    
    public void PlayGameOverSound()
    {
        _audioSource.clip = _gameOver;
        _audioSource.Play();
    }
}
