using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_A : MonoBehaviour
{

    private void Start()
    {
        var b = transform.Find("B");
        print(b.name);
        var c = transform.Find("B/C");
        print(c.name);
    }
}
