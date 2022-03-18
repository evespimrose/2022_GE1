using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_A : MonoBehaviour
{
    public GameObject m_studyBGameObject;

    private void Start()
    {
        m_studyBGameObject = new GameObject(name: "B");
        m_studyBGameObject.AddComponent<Study_B>();
        m_studyBGameObject.AddComponent<Study_C>();
        print(m_studyBGameObject.name);

        // var study_b = m_studyBGameObject.GetComponent<Study_B>();
        // study_b.SendMessage("SayHello");
        
        m_studyBGameObject.SendMessage(methodName:"Say hello");
    }
}
