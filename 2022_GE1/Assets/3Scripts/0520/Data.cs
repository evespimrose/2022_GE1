using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

[Serializable]
public class Data
{
    public Dictionary<string, int> SomeDictionary;
    public Queue<int> SomeQueue;
    public string dataName;
    public int age;
    public float height;
    public Vector3 playerPosition;

    [JsonIgnore] // 직렬화에서 제외
    public Quaternion playerRotation;
}
