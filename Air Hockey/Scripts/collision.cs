using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    [SerializeField] private float speed;
    public float force = 10f;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            /*Debug.Log("Puck collided with wall");*/
            Vector3 incomingDirection = transform.position - collision.contacts[0].point;
            Vector3 wallNormal = collision.contacts[0].normal;
            Vector3 reflectedDirection = Vector3.Reflect(incomingDirection, wallNormal);
           
            GetComponent<Rigidbody>().velocity = reflectedDirection.normalized * speed;
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            Vector3 direction = collision.contacts[0].normal;
            rigidbody.AddForce(direction * force, ForceMode.Impulse);
        }
    }
    

 
}



