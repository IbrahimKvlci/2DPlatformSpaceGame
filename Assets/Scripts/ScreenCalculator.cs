using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCalculator : MonoBehaviour
{
    public static ScreenCalculator _instance;

    float _height;
    float _width;

    public float Height
    {
        get { return _height; }
    }

    public float Width
    {
        get { return _width; }
    }

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }else if (_instance != this)
        {
            Destroy(gameObject);
        }

        _height = Camera.main.orthographicSize;
        _width = _height * Camera.main.aspect;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
