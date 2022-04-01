using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _direction;
    public float Speed;

    public float jumpPower;
    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var hor = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");

        _direction = new Vector3(hor, 0, ver);
 
        if (Input.GetKeyDown(KeyCode.Space))
            _direction += new Vector3(0, jumpPower, 0);

        if (Input.GetMouseButtonDown(0))
        {
            var pos = Input.mousePosition;
            var cam = FindObjectOfType<Camera>();
            
            var ray = cam.ScreenPointToRay(pos);
            if (Physics.Raycast(ray, out var hitInfo))
            {
                print(hitInfo.collider.name);
            }
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(_direction * Time.deltaTime * Speed);
    }
}
