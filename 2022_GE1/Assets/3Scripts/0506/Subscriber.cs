using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscriber : MonoBehaviour
{
    public string eventName;
    // Start is called before the first frame update
    public void Start()
    {
        EventManager.Instance.Subscribe(eventName, OnEvent);
    }

    // Update is called once per frame
    private void OnEvent(object param)
    {
        print($"{gameObject.name} : {eventName}이 발동됨, 파라미터는 : {param}");
    }
}
