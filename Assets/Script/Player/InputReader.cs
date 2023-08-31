using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "SO/INPUTREADER")]
public class InputReader : ScriptableObject
{
    public event Action<Vector2> MovementEvent;
    public Vector2 AimPosition { get; private set; }
    private Controlls _controlls;

    private void OnEnable()
    {
        if (_controlls == null)
        {
            _controlls = new Controlls();
            _controlls.ActionMap.SetCallbacks(this);
        }

        _controlls.ActionMap.Enable();
    }
}
