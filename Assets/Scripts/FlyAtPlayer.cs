using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 6f;
    [SerializeField] float stopDistance = 0.3f;

    Transform target;
    bool launched;

    // Called by TriggerProjectile
    public void LaunchTowards(Transform t)
    {
        target = t;
        launched = true;

        // If you hid by disabling MeshRenderer (and left object active initially), re-enable here.
         var mr = GetComponentInChildren<MeshRenderer>();
         if (mr) mr.enabled = true;
    }

    void Update()
    {
        if (!launched || target == null) return;

        Vector3 dest = target.position;
        transform.position = Vector3.MoveTowards(transform.position, dest, speed * Time.deltaTime);

        // Optional: face the target
        Vector3 dir = dest - transform.position;
        if (dir.sqrMagnitude > 0.0001f) transform.forward = dir.normalized;

        // Do NOT compare Vector3 equality; use a radius
        if ((dest - transform.position).sqrMagnitude <= (stopDistance * stopDistance))
        {
            Destroy(gameObject); // or pool/disable if you prefer
        }
    }
}