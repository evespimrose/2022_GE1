using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("test",1000);
        print(PlayerPrefs.GetInt("test"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
