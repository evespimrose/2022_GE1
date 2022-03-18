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
        print(m_studyBGameObject.name);
        Destroy(m_studyBGameObject);
    }
}
