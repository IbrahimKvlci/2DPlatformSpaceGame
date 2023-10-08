using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Collider2D _col;

    float _randomSpeed;
    float _min, _max;

    bool _movement;

    public bool Movement
    {
        get { return _movement; }
        set { _movement = value; }
    }

    void Start()
    {
        _col = GetComponent<Collider2D>();
        _randomSpeed = Random.Range(0.5f, 1);

        float _objectSize = _col.bounds.size.x/2;

        if (transform.position.x > 0)
        {
            _min = _objectSize;
            _max = ScreenCalculator._instance.Width-_objectSize;
        }
        else
        {
            _min = -ScreenCalculator._instance.Width + _objectSize;
            _max = -_objectSize;
        }

    }

    void Update()
    {
        if (_movement)
        {
            float pingPongX = Mathf.PingPong(Time.time*_randomSpeed,_max-_min)+_min;
            Vector2 pingPong = new Vector2(pingPongX, transform.position.y);
            transform.position = pingPong;  
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Foot")
        {
            GameObject.FindGameObjectWithTag("Player").transform.parent = transform;
            GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerMovement>().ResetJumpCount();
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Foot")
        {
            GameObject.FindGameObjectWithTag("Player").transform.parent = null;
        }
    }

}
