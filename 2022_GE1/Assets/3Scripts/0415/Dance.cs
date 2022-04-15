using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dance : MonoBehaviour
{
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void OnDance(InputValue value)
    {
        if(!_isDancing)
            StartCoroutine(DanceRoutine());
    }

    private bool _isDancing;

    IEnumerator DanceRoutine()
    {
        _animator.SetBool("IsDance",true);
        _isDancing = true;
        
        yield return new WaitForSeconds(1.5f);
        
        _animator.SetBool("IsDance",false);
        _isDancing = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
