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
        //UnityEngine.Time.timeScale = 0.5f;        // 엔진 내부 시간을 0.5배로
        var _elapsedTime = 0f;
        while (true)
        {
            //yield return new WaitForSecondsRealtime(1f);
            yield return null;
            //yield return new WaitForFixedUpdate;

            _elapsedTime += UnityEngine.Time.deltaTime;

            timerText.text = _elapsedTime.ToString();
        }
    }
}
