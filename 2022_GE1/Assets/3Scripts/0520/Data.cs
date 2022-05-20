using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Data
{
    public Dictionary<string, int> SomeDictionary;
    public Queue<int> SomeQueue;
    public string dataName;
    public int age;
    public float height;
    public Vector3 playerPosition;
    public Quaternion playerRotation;
}
