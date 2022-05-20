using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Threading;

public class WaitTime : MonoBehaviour
{
    void Start()
    {
        Task.Run(Wait);
    }

    // async : �񵿱�� �۵��ϴ� �޼���
    async void Wait()
    {
        print("Hey");
        await Task.Delay(1000);
        print("Hi");
    }
}
