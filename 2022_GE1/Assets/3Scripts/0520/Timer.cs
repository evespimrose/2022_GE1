using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;

    private float _elapsedTime;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        var flooredValue = Mathf.Floor(_elapsedTime);

        timerText.text = $"{flooredValue:80}";

        timerText.text = _elapsedTime.ToString();
    }
}
