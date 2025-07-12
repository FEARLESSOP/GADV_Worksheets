using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Implulse : MonoBehaviour
{
    public float forceAmount = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * forceAmount, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * forceAmount, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * forceAmount, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);
        }
    }
}
