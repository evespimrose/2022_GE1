using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slyme : Monster
{
    // Start is called before the first frame update
    public override void Cry()
    {
        print(message:"'철퍽철퍽' 투명슬라임이 통통 뛰었다.");
    }
}
