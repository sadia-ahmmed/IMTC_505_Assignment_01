using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float spinX=0f;
    [SerializeField] float spinY=3f;
    [SerializeField] float spinZ=0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its local X, Y, and Z axes it is applied to the spinner object to create interesting obstacle 
        transform.Rotate(spinX, spinY, spinZ );
    }
}
