using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    void CheckLineOfSight()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        RaycastHit hitData;

        foreach (GameObject enemy in enemies)
        {
            Vector3 direction = enemy.transform.position - transform.position;
            Debug.DrawRay(transform.position, direction, Color.red);

            if (Physics.Raycast(transform.position, direction, out hitData, 30f))
            {
                if (hitData.transform.CompareTag("Enemy"))
                {
                    Debug.DrawRay(transform.position, direction, Color.green);
                    Debug.Log($"Enemy {hitData.transform.name} is visible.");
                }
                else
                {
                    Debug.Log($"Ray hit: {hitData.transform.name}, not an enemy.");
                }
            }
        }
    }

    private void Start()
    {
        CheckLineOfSight();
    }
}