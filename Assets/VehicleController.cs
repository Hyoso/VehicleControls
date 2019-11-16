using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public float m_speed = 5.0f;
    public Rigidbody rigid;

    private void Start()
    {
        Debug.Log(rigid.centerOfMass);
//        rigid.centerOfMass = Vector3.down * 1.5f;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
        }
    }

    private void FixedUpdate()
    {
        rigid.AddForce(transform.right * m_speed);
    }

    private void OnValidate()
    {
        if (rigid == null)
        {
            rigid = GetComponent<Rigidbody>();
        }
    }
}
