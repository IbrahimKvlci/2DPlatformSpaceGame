using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float _speed;
    float _speedBoost;
    float _maxSpeed;

    bool _isMoving=true;

    void Start()
    {
        switch (Prefs.GetDifficulty())
        {
            case 0:
                _speed = 0.3f;
                _speedBoost = 0.03f;
                _maxSpeed = 1.5f;
                break;
            case 1:
                _speed = 0.5f;
                _speedBoost = 0.05f;
                _maxSpeed = 2;
                break;
            case 2:
                _speed = 0.8f;
                _speedBoost = 0.08f;
                _maxSpeed = 2.5f;
                break;
            default:
                break;
        }

        
    }


    private void FixedUpdate()
    {

        if (_isMoving)
        {
            MoveCamera();
        }
    }

    void MoveCamera()
    {
        transform.position += transform.up * _speed * Time.deltaTime;
        _speed += _speedBoost * Time.deltaTime;
        if (_speed > _maxSpeed)
        {
            _speed = _maxSpeed;
        }
    }


}
