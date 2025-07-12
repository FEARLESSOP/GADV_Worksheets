using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotate : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(45f, 45f, 45f);

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
