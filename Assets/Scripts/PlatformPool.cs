using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPool : MonoBehaviour
{
    [SerializeField] GameObject _platformPrefab;
    [SerializeField] GameObject _deadlyPlatformPrefab;
    [SerializeField] GameObject _playerPefab;

    List<GameObject> _platforms = new List<GameObject>();

    Vector2 _platformPosition;
    Vector2 _playerPosition;

    [SerializeField] float _platformDistanceY;

    void Start()
    {
        CreatePlatform();
    }

    void Update()
    {
        if (_platforms[_platforms.Count - 1].transform.position.y < 
            Camera.main.transform.position.y + ScreenCalculator._instance.Height)
        {
            PlacePlatform();
        }   
    }

    void CreatePlatform()
    {
        _platformPosition = new Vector2(0, 0);
        _playerPosition=new Vector2(0, 0.5f);

        GameObject player = Instantiate(_playerPefab, _playerPosition, Quaternion.identity);
        GameObject firstPlatform=Instantiate(_platformPrefab,_platformPosition, Quaternion.identity);

        _platforms.Add(firstPlatform);
        NextPlatformPosition();

        firstPlatform.GetComponent<Platform>().Movement = true;

        for (int i = 0; i < 8; i++)
        {
            GameObject platform = Instantiate(_platformPrefab, _platformPosition, Quaternion.identity);
            _platforms.Add(platform);
            platform.GetComponent<Platform>().Movement = true;
            if (i % 2 == 0)
            {
                platform.GetComponent<Gold>().OnGold();
            }
            NextPlatformPosition();
        }

        GameObject deadlyPlatform = Instantiate(_deadlyPlatformPrefab, _platformPosition, Quaternion.identity);
        deadlyPlatform.GetComponent<DeadlyPlatform>().Movement = true;
        _platforms.Add(deadlyPlatform);
        NextPlatformPosition();
    }

    void PlacePlatform()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject temp;
            temp = _platforms[i + 5];
            _platforms[i + 5] = _platforms[i];
            _platforms[i] = temp;
            _platforms[i + 5].transform.position = _platformPosition;
            if (_platforms[i + 5].gameObject.tag == "Platform")
            {
                _platforms[i + 5].GetComponent<Gold>().OffGold();
                float randomGold = Random.Range(0.0f, 1.0f);
                print(randomGold);
                if (randomGold > 0.4f)
                {
                    print("a");
                    _platforms[i + 5].GetComponent<Gold>().OnGold();
                }
            }
            NextPlatformPosition();
        }
    }

    void NextPlatformPosition()
    {
        _platformPosition.y += _platformDistanceY;
        float random = Random.Range(0, 2);
        if (random < 1f)
        {
            _platformPosition.x = ScreenCalculator._instance.Width / 2;
        }
        else
        {
            _platformPosition.x = -ScreenCalculator._instance.Width / 2;
        }
    }
}
