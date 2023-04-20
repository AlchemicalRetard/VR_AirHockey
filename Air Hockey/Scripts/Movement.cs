using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float MoveSpeed=2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(rb.position + Vector3.right * Time.deltaTime * MoveSpeed);
            Debug.Log("A pressed");
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(rb.position + Vector3.left * Time.deltaTime * MoveSpeed);
            //Debug.Log("A pressed");
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(rb.position + Vector3.back * Time.deltaTime * MoveSpeed);
           // Debug.Log("A pressed");
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(rb.position + Vector3.forward * Time.deltaTime * MoveSpeed);
            //Debug.Log("A pressed");
        }
    }
}
