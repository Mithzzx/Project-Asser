using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] GameObject lightt;
    [SerializeField] float throttleIncrement;
    [SerializeField] float Hp = 10f;
    [SerializeField] float maxSpeed;
    [SerializeField] float steer = 10f;
    [SerializeField] float liftMagnitude;
    [SerializeField] GameObject[] Lasers;

    float throttle;
    float pich;
    float yaw;
    float roll;

    [Header("Sensitivity")]
    [SerializeField] float pichSensitivity;
    [SerializeField] float yawSensitivity;
    [SerializeField] float rollSensitivity;


    Rigidbody rb;
    Vector3 startPos;
    

    void Start()
    {
        Application.targetFrameRate = 50;
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
    }


    void Update()
    {
        ProcessThrust();
        ProcessShootig();
        CheetCode();
    }

    private void ProcessShootig()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            IsFiring(true);
        }
        else
        {
            IsFiring(false);
        }
    }
    void IsFiring(bool Active)
    {
        foreach (GameObject laser in Lasers)
        {
            var emmisionModule = laser.GetComponent<ParticleSystem>().emission;
            emmisionModule.enabled = Active;
        }
    }
    private void FixedUpdate()
    {
        if (rb.velocity.magnitude < maxSpeed)
             rb.AddRelativeForce(Vector3.forward * Hp * throttle);
        rb.AddRelativeTorque(Vector3.forward * pich * steer * pichSensitivity);
        rb.AddRelativeTorque(Vector3.right * yaw * steer * yawSensitivity);
        rb.AddRelativeTorque(Vector3.up * roll * steer * rollSensitivity);
        rb.AddRelativeForce(Vector3.up * rb.velocity.magnitude * liftMagnitude);
    }

    void ProcessThrust()
    {
        pich = Input.GetAxis("Pich");
        yaw = Input.GetAxis("Yaw");
        roll = Input.GetAxis("Roll");

        if (rb.velocity.magnitude < maxSpeed ) 
        {
            if (Input.GetKey(KeyCode.W))
            {
                lightt.gameObject.SetActive(true);
                throttle += throttleIncrement;
            }
            else if (Input.GetKey(KeyCode.S)) throttle -= throttleIncrement;
            else lightt.gameObject.SetActive(false);
        }
        
        throttle = Mathf.Clamp(throttle, 0f , 100f);

    }
    void CheetCode()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.position = startPos;
        }    
    }

}
