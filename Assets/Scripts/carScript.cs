using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class carScript : MonoBehaviour
{
    public Transform centerOfMass;
    public WheelCollider whellColliderLeftFront;
    public WheelCollider whellColliderRightFront;
    public WheelCollider whellColliderLeftBack;
    public WheelCollider whellColliderRightBack;

    public Transform whellLeftFront;
    public Transform whellRighFront;
    public Transform whellLeftBack;
    public Transform whellRightBack;

    public float motorTorque = 100f;
    public float maxSteer = 20f;
    private Rigidbody rb;
    public Collider carCol;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centerOfMass.localPosition;
    }

    void FixedUpdate()
    {
        whellColliderLeftBack.motorTorque = Input.GetAxis("Vertical") * motorTorque;
        whellColliderRightBack.motorTorque = Input.GetAxis("Vertical") * motorTorque;

        whellColliderLeftFront.steerAngle = Input.GetAxis("Horizontal") * maxSteer;
        whellColliderRightFront.steerAngle = Input.GetAxis("Horizontal") * maxSteer;



    }

    void Update()
    {
        var pos = Vector3.zero;
        var rot = Quaternion.identity;

        whellColliderLeftFront.GetWorldPose(out pos, out rot);
        whellLeftFront.position = pos;
        whellLeftFront.rotation = rot;

        whellColliderRightFront.GetWorldPose(out pos, out rot);
        whellRighFront.position = pos;
        whellRighFront.rotation = rot;

        whellColliderLeftBack.GetWorldPose(out pos, out rot);
        whellLeftBack.position = pos;
        whellLeftBack.rotation = rot;

        whellColliderRightBack.GetWorldPose(out pos, out rot);
        whellRightBack.position = pos;
        whellRightBack.rotation = rot;
    }
  
  
}