using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private UnityEvent<Vector3> _playerMoveInput = null;
    [SerializeField] private UnityEvent _playerMoveStopInput = null;
    private Vector3 dir;

    private void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (dir.sqrMagnitude != 0)
            _playerMoveInput?.Invoke(dir);
        else
            _playerMoveStopInput?.Invoke();
    }
}
