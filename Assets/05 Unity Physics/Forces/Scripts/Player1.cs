using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player1 : MonoBehaviour
{
    public float speed = 6.0f;
    public float rotateSpeed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private int jumps;
    CharacterController controller;

    public float radius = 5.0F;
    public float power = 10000.0F;

    public float kickStrength = 500.0F;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.detectCollisions = false;
    }

    void CheckExplosion()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            var surroundingObjects = Physics.OverlapSphere(transform.position, radius);

            foreach (var obj in surroundingObjects)
            {
                var rb = obj.GetComponent<Rigidbody>();
                if (rb == null) continue;

                rb.AddExplosionForce(power, transform.position, radius);
            }
        }
    }
    void Kick()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            var surroundingObjects = Physics.OverlapBox(transform.position + transform.forward, new Vector3(2, 5, 2), transform.rotation);
            foreach (var obj in surroundingObjects)
            {
                var rb = obj.GetComponent<Rigidbody>();
                if (rb == null) continue;
                rb.AddForce(transform.forward * kickStrength);
            }
        }
    }

    private void Update()
    {
        CheckExplosion();
        Kick();
    }

    void FixedUpdate()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            if (moveDirection.x > 0)
            {
                moveDirection = transform.TransformDirection(moveDirection);
            }

            moveDirection *= speed;
            if (Input.GetButtonDown("Fire1"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        transform.Rotate(moveDirection);
    }
}