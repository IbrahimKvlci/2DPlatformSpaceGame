using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    public static MusicControl _instance;

    AudioSource _audioSource;
    
    void Awake()
    {
        Singleton();
        _audioSource= GetComponent<AudioSource>();
    }

    void Singleton()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }
    }

    public void PlayMusic(bool play)
    {
        if (play)
        {
            if (!_audioSource.isPlaying)
            {
                _audioSource.Play();
            }
        }
        else
        {
            if (_audioSource.isPlaying)
            {
                _audioSource.Stop();
            }
        }
    }
}
