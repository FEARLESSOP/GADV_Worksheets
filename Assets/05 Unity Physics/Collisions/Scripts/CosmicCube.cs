using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmicCube : MonoBehaviour
{
    private Renderer cubeRenderer;

    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.material.color = Color.red;
    }

    void OnCollisionEnter(Collision collision)
    {
        cubeRenderer.material.color = Color.green;
    }

    void OnCollisionExit(Collision collision)
    {
        cubeRenderer.material.color = Color.red;
    }
}