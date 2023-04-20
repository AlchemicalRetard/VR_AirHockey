using UnityEngine;

public class Fix : MonoBehaviour
{
    public float force = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get the current velocity of the object
        Vector3 velocity = rb.velocity;

        // Check if the object is moving in the positive or negative Z direction
        if (velocity.z > 0)
        {
            // Add a force in the positive Z direction
            rb.AddForce(Vector3.forward * force);
        }
        else if (velocity.z < 0)
        {
            // Add a force in the negative Z direction
            rb.AddForce(Vector3.back * force);
        }
    }
}
