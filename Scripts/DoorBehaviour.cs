using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public void OnInteract()
    {
        Vector3 doorRotation = transform.eulerAngles;
        doorRotation.y += 90f; //rotates door 90 degrees
        transform.eulerAngles = doorRotation; //to apply the rotation
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Press E to interact
        {
            OnInteract();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnInteract();
        }
    }
}