using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleActionMap : MonoBehaviour
{
    public PlayerInput _PlayerInput;

    public void ToggleMap()
    {
        if(_PlayerInput.currentActionMap.name == "Game")
            _PlayerInput.SwitchCurrentActionMap("UI");
        else
            _PlayerInput.SwitchCurrentActionMap("Game");
    }
}
