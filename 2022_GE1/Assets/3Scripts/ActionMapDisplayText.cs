using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionMapDisplayText : MonoBehaviour
{
    public PlayerInput _playerInput;
    private TMP_Text _text;
    // Start is called before the first frame update
    void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = _playerInput.currentActionMap.name;
    }
}
