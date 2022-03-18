using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_A : MonoBehaviour
{
    public GameObject m_studyBGameObject;

    private void Start()
    {
        m_studyBGameObject = GameObject.Find("B");
        print(m_studyBGameObject.name);
    }
}
