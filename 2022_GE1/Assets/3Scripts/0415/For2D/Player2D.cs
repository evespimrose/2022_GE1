using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2D : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void OnMove(InputValue value)
    {
        var direction = value.Get<Vector2>();
        _animator.SetFloat("Horizontal",direction.x);
        _animator.SetFloat("Vertical",direction.y);

    }
    
    void Update()
    {
        
    }
}
