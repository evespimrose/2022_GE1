using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var data = new Data
        {
            SomeDictionary = new Dictionary<string, int>(),
            dataName = "홍길동",
            age = 100000,
            height = 1.9f,
            playerPosition = new Vector3(1, 2, 3),
            playerRotation = Quaternion.Euler(20, 30, 90)
        };
        // 유니티에서 제공하는 JsonUtility에서 커버 안쳐줌
        data.SomeDictionary.Add("hey", 101010);
        var jsonStr = JsonUtility.ToJson(data);
        print(jsonStr);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
