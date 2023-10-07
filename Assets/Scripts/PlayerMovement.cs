using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D _rb;
    Animator _animator;

    Vector2 _velocity;

    void Start()
    {
        _rb=GetComponent<Rigidbody2D>();
        _animator=GetComponent<Animator>();
    }

    
    void FixedUpdate()
    {
        KeyboardControl();
    }

    void KeyboardControl()
    {
        float movementInput = Input.GetAxisRaw("Horizontal");
        Vector2 scale = transform.localScale;

        if (movementInput > 0)
        {
            _velocity.x = Mathf.MoveTowards(_velocity.x, movementInput * 3.0f, 10.0f * Time.deltaTime);
            _animator.SetBool("Walk", true);
            scale.x = Mathf.Abs(scale.x);
        }
        else if (movementInput < 0)
        {
            _velocity.x = Mathf.MoveTowards(_velocity.x, movementInput * 3.0f, 10.0f * Time.deltaTime);
            _animator.SetBool("Walk", true);
            scale.x = -Mathf.Abs(scale.x);
        }
        else
        {
            _velocity.x = Mathf.MoveTowards(_velocity.x, 0, 50);
            _animator.SetBool("Walk", false);
        }

        transform.localScale = scale;
        transform.Translate(_velocity * Time.deltaTime);
    }
}
