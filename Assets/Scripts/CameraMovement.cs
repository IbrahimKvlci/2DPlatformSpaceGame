using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float _speed;
    float _speedBoost;
    float _maxSpeed;

    bool _isMoving;

    void Start()
    {
        _speed = 0.5f;
        _speedBoost = 0.05f;
        _maxSpeed = 2f;
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
