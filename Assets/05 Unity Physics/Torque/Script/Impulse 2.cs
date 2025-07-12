using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse2 : MonoBehaviour
{
    public float torqueAmount = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.AddTorque(Vector3.down * torqueAmount, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.AddTorque(Vector3.up * torqueAmount, ForceMode.Impulse);
        }
    }
}