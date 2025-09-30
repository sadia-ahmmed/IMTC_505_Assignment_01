using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 10f;
    // [SerializeField] public float rotationSpeed = 100f;
    private Rigidbody rb;
    public GameObject trailSpherePrefab;

    void Start()
    {
        PrintInstructions();
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        MovePlayer();
    }
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using arrow keys or wasd");
        Debug.Log("Don't bump into objects!");

    }
    void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(x, 0, z);

        // Move using Rigidbody to enable collision
        rb.MovePosition(rb.position + move * speed * Time.deltaTime);


        if (move != Vector3.zero)
        {
            GameObject s = Instantiate(trailSpherePrefab, transform.position, Quaternion.identity);

            var renderers = s.GetComponentsInChildren<MeshRenderer>(true);
            foreach (var r in renderers)
                r.enabled = true;

            // Give it a random visible color
            Color c = Random.ColorHSV(0f, 1f, 0.9f, 1f, 0.9f, 1f);
            foreach (var r in renderers)
            {
                r.material.SetColor("_BaseColor", c); // URP Lit
                r.material.SetColor("_Color", c);     // Built-in fallback
            }

            Destroy(s, 5f);
        }

    }
}
