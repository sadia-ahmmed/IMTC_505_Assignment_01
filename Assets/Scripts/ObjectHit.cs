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
    
        // when collision occurs with the player, change color to red and change tag to "Hit"
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";

        }
        // Play the hit sound when colision occurs
        if (hitSound != null)
        {
            hitSound.Play();
        }

        // GetComponent<MeshRenderer>().material.color = Color.red;
        // Debug.Log("Something Hit me!");

    }
}
