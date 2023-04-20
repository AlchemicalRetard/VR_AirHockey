using UnityEngine;

public class GiveImpulse : MonoBehaviour
{
    public float force = 10f;

    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Vector3 direction = Random.onUnitSphere;
        rigidbody.AddForce(direction * force, ForceMode.Impulse);
    }
}
