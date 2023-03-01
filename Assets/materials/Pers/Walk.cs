using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _input;

    [SerializeField] private SpriteRenderer _characterSprite;

    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        _input = new Vector2(Input.GetAxis("Horizontal"), 0);
        transform.position += _input * _speed * Time.deltaTime;

        if (_input.x != 0)
        {
            _characterSprite.flipX = _input.x > 0 ? false : true;
        }
    }
}
