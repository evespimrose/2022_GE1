using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study_A : MonoBehaviour
{
    public GameObject m_studyBGameObject;

    private void Start()
    {
        m_studyBGameObject = GameObject.FindObjectOfType<Study_B>().gameObject;
        print(m_studyBGameObject.name);
    }
}
