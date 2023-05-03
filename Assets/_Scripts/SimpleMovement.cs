using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    private Vector3 _input;
    private Rigidbody2D _rigidbody2D;
    private float _velocity = 5f;

    void Awake()
    {
        _rigidbody2D= GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _input.x = Input.GetAxisRaw("Horizontal");
        _rigidbody2D.velocity = _velocity * _input;

    }

}
