using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventEmitter : MonoBehaviour
{
    public string eventName;
    public int param;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            EventManager.Instance.Emit(eventName, param);
        }
    }

}
