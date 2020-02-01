using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    Rigidbody rb;
    public float mouvementSpeed = 2.0f;
    public float rotationSpeed = 2.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = transform.right * mouvementSpeed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = -transform.right * mouvementSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
    }
}