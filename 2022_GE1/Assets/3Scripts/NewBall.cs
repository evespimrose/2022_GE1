using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBall : MonoBehaviour
{
   private Vector3 _direction;
   private Rigidbody _rigidbody;

   private void Awake()
   {
      _rigidbody = GetComponent<Rigidbody>();
   }

   public void OnMove(InputValue value)
   {
      var rawvalue = value.Get<Vector2>();
      _direction = new Vector3(rawvalue.x, 0.0f, rawvalue.y);
   }
   
   private void FixedUpdate()
   {
      _rigidbody.AddForce(_direction * Time.deltaTime);
   }
}
