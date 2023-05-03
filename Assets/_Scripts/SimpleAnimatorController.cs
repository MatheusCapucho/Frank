using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimatorController : MonoBehaviour
{
    private float _input;
    private Animator _animator;
    private bool _facingRight = true;
    void Awake()
    {
        _animator= GetComponent<Animator>();
    }
    void Update()
    {
        _input = Input.GetAxisRaw("Horizontal");
        _animator.SetFloat("XInput", Mathf.Abs(_input));

        Flip();

    }

    private void Flip()
    {
        if (_input > 0 && !_facingRight)
        {
            var scale = transform.localScale;
            scale.x *= -1f;
            transform.localScale = scale;
            _facingRight = !_facingRight;
        }
        else
        if (_input < 0 && _facingRight)
        {
            var scale = transform.localScale;
            scale.x *= -1f;
            transform.localScale = scale;
            _facingRight = !_facingRight;
        }
    }
}
