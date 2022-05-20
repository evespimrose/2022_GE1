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
            dataName = "ȫ�浿",
            age = 100000,
            height = 1.9f,
            playerPosition = new Vector3(1, 2, 3),
            //playerRotation = transform.localRotation.eulerAngles
        };
        // ����Ƽ���� �����ϴ� JsonUtility���� Ŀ�� ������
        data.SomeDictionary.Add("hey", 101010);
        var jsonStr = JsonUtility.ToJson(data);

        // json�� ���� �����Ұ��� ���ϰ�, ���ϸ�带 ����� ���� �Ѵ�.
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
