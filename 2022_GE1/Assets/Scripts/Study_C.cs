using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_C : MonoBehaviour
{
    private void Start()
    {
        var b = transform.parent;
        print(b.name);
    }
}
