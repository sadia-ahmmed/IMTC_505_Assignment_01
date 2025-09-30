using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] AudioSource hitSound;

    void Awake()
    {
        // Grab the AudioSource on this object
        hitSound = GetComponent<AudioSource>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";

        }
        if (hitSound != null)
        {
            hitSound.Play();
        }

        // GetComponent<MeshRenderer>().material.color = Color.red;
        // Debug.Log("Something Hit me!");

    }
}
