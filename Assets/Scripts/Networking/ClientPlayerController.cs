    using System;
    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientPlayerController : MonoBehaviour
{
    private bool  _updateRot;
    [SerializeField]private float _speedUpdatePos;
    private Vector3 _position;
    private Quaternion _rotation;
    public void SetPosition(Vector3 position)
    {
        _position = position;
    }

    public void SetRotation(Quaternion rotation)
    {
        _updateRot = true;
        _rotation = rotation;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _position, _speedUpdatePos * Time.deltaTime);
        if (_updateRot)
        {
            transform.rotation = _rotation;
            _updateRot = false;
        }
    }
}
