using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Activate(projectile,  other.transform);
        Activate(projectile1, other.transform);
        Activate(projectile2, other.transform);
        Activate(projectile3, other.transform);

        Destroy(gameObject); // remove the trigger after firing
    }

    void Activate(GameObject go, Transform target)
    {
        if (go == null) return;

        var fly = go.GetComponent<FlyAtPlayer>();
        if (fly == null)
        {
            Debug.LogError("FlyAtPlayer missing on " + go.name);
            return;
        }

        // If you chose to hide via MeshRenderer instead of deactivating:
        // var mr = go.GetComponentInChildren<MeshRenderer>();
        // if (mr) mr.enabled = true;

        go.SetActive(true);        // reveal + enable lifecycle
        fly.LaunchTowards(target); // start homing
    }
}