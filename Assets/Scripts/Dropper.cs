using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created    [SerializeField] float timeToWait=5f;

    MeshRenderer dropperMeshRenderer;
    Rigidbody rb;
    float timeToWait = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dropperMeshRenderer = GetComponent<MeshRenderer>();
        dropperMeshRenderer.enabled = false;

        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
        if (Time.time > timeToWait)
        {

            // Debug.Log("Lookout Below!");
            dropperMeshRenderer.enabled = true;
            rb.useGravity = true;
             
        }
    }
}
