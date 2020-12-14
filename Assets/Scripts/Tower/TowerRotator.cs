using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class TowerRotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float torque = touch.deltaPosition.x * _rotateSpeed * Time.deltaTime;
            if(touch.phase == TouchPhase.Moved)
            {
                _rigidbody.AddTorque(Vector3.up * torque);
            }
        }
    }
}
