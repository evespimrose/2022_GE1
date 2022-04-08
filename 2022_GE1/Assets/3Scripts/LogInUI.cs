using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LogInUI : MonoBehaviour
{
    public TMP_InputField idField;
    public TMP_InputField pwField;
    public TMP_Text panelText;

    public Button loginButton;

    public GameObject loginPanel;

    private void Start()
    {
        loginButton.onClick.AddListener(OnLoginButtonClicked);
    }

    public void OnLoginButtonClicked()
    {
        if (idField.text == "admin" && pwField.text == "1q2w3e4r")
        {
            loginPanel.SetActive(true);
            panelText.text = "로그인에 성공했습니다.";
        }
        else
        {
            loginPanel.SetActive(true);
            panelText.text = "로그인에 실패했습니다.";
        }
    }
}
