using UnityEngine;
using TMPro;

public class KeyBehaviour : MonoBehaviour
{
    [SerializeField] DoorBehaviour MainDoor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ensure that it is the correct game object 
        {
            Debug.Log("Key is collected!");

            PlayerBehaviour player = other.GetComponent<PlayerBehaviour>();
            if (player != null)
            {
                player.HasKey = true; // Set key flag to true
            }



            Destroy(gameObject); // Remove key from scene
        }
    }
}
