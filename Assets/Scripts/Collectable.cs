using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))  // Check if the object entering the trigger is the player
        {
            Debug.Log("Collectible picked up!");
            Destroy(gameObject);  // Destroy the collectible
        }
    }
}