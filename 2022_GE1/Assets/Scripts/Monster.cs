using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// abstract : 추상 클래스.
public abstract class Monster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(message:"'크아아' 투명몬스터가 울부짖었다");
        Cry();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void Cry();

}
