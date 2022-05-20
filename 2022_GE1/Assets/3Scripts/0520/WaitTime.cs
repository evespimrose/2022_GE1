using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Threading;

public class WaitTime : MonoBehaviour
{
    void Start()
    {
        var thread = new Thread(Run);
        thread.Start();
    }

    private void Run()
    {
        print("Hey");
        Thread.Sleep(1000);
        print("Hi");
    }
}
