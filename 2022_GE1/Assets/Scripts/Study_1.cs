using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_1 : MonoBehaviour
{
    private const float AttackInterval = 3f;
    private float _attackIntervalTimer;

    private void Start()
    {
        Invoke(methodName:"PrintText",time:3f);
    }
    
    void Update()
    {
        
    }

    void PrintText()
    {
        print(message:"공격!");
    }
}
