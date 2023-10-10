using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _jumpForce;
    [SerializeField] float _jumpLimit = 3;

    Rigidbody2D _rb;
    Animator _animator;
    Joystick _joystick;
    JoystickButton _joystickButton;

    Vector2 _velocity;

    float _jumpCount;
    float _horizontal;

    bool _isJumping;

    void Start()
    {
        _joystickButton=FindObjectOfType<JoystickButton>();
        _rb=GetComponent<Rigidbody2D>();
        _animator=GetComponent<Animator>();
        _joystick = FindObjectOfType<Joystick>();
    }

    
    void Update()
    {
#if UNITY_EDITOR
        KeyboardControl();
#else
        JoystickControl();
#endif

    }

    void Move()
    {
        Vector2 scale = transform.localScale;

        if (_horizontal > 0)
        {
            _velocity.x = Mathf.MoveTowards(_velocity.x, _horizontal * 3.0f, 10.0f * Time.deltaTime);
            _animator.SetBool("Walk", true);
            scale.x = Mathf.Abs(scale.x);
        }
        else if (_horizontal < 0)
        {
            _velocity.x = Mathf.MoveTowards(_velocity.x, _horizontal * 3.0f, 10.0f * Time.deltaTime);
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

    void KeyboardControl()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        Move();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StopJump();
        }
    }

    void JoystickControl()
    {
        _horizontal = _joystick.Horizontal;
        Move();

        if (_joystickButton._clickedButton&&!_isJumping)
        {
            _isJumping = true;
            Jump();
        }
        if (!_joystickButton._clickedButton && _isJumping)
        {
            _isJumping = false;
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
