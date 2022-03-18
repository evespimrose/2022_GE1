using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_1 : MonoBehaviour
{
    private const float AttackInterval = 3f;
    private float _attackIntervalTimer;
    void Update()
    {
        _attackIntervalTimer += Time.deltaTime;
        if (_attackIntervalTimer > 3f)
        {
            PrintText();
            _attackIntervalTimer = 0f;
        }
    }

    void PrintText()
    {
        print(message:"공격!");
    }
}
