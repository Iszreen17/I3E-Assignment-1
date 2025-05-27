using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public void Interact()
    {
        Vector3 doorRotation = transform.eulerAngles;
        doorRotation.y += 90f;
        transform.eulerAngles = doorRotation;
   }
}
