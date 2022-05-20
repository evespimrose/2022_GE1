using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;

    private void Start()
    {
        StartCoroutine(Time());
    }

    private IEnumerator Time()
    {
        var _elapsedTime = 0f;
        while (true)
        {
            yield return new WaitForSeconds(1f);
            _elapsedTime++;

            timerText.text = _elapsedTime.ToString();
        }
    }
}
