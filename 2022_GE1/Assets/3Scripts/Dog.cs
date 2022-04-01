using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Monster
{
    public override void Cry()
    {
        print(message:"'멍멍' 투명강아지가 멍멍 짖었다.");
    }
}
