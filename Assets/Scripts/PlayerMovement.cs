using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _jumpForce;
    [SerializeField] float _jumpLimit = 3;

    Rigidbody2D _rb;
    Animator _animator;

    Vector2 _velocity;

    float _jumpCount;


    void Start()
    {
        _rb=GetComponent<Rigidbody2D>();
        _animator=GetComponent<Animator>();
    }

    
    void Update()
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StopJump();
        }
    }

    void Jump()
    {
        if (_jumpCount < _jumpLimit)
        {
            _rb.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
            _animator.SetBool("Jump", true);
        }
        
    }

    void StopJump()
    {
        _animator.SetBool("Jump", false);
        _jumpCount++;
    }

    public void ResetJumpCount()
    {
        _jumpCount = 0;
    }
}
