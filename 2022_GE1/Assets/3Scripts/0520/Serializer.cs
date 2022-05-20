using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using Newtonsoft.Json;


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
            //playerRotation = transform.localRotation.eulerAngles
        };
        // 유니티에서 제공하는 JsonUtility에서 커버 안쳐줌
        data.SomeDictionary.Add("hey", 101010);
        var jsonStr = JsonUtility.ToJson(data);

        // json을 어디다 저장할건지 정하고, 파일모드를 만들기 모드로 한다.
        using (var filestream = new FileStream(Path.Combine(Application.persistentDataPath, "save.json"),FileMode.Create))
        {
            byte[] jsonByteArray = Encoding.UTF8.GetBytes(jsonStr);

            filestream.Write(jsonByteArray);
        }

        print(jsonStr);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
