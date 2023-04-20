using UnityEngine;

public class PuckFollow: MonoBehaviour
{
    public float range = 10f;
    public string targetTag = "Target";
    public float speed = 20f;

    private Transform target;

    void Update()
    {
        if (target == null)
        {
            target = FindTarget();
        }
        else
        {
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance > range)
            {
                target = null;
            }
            else
            {
                Vector3 newPos = transform.position;
                newPos.x = Mathf.Lerp(transform.position.x, target.position.x, Time.deltaTime * speed);
                transform.position = newPos;
            }
        }
    }

    private Transform FindTarget()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag(targetTag);
        foreach (GameObject t in targets)
        {
            float distance = Vector3.Distance(transform.position, t.transform.position);
            if (distance <= range)
            {
                return t.transform;
            }
        }
        return null;
    }
}
