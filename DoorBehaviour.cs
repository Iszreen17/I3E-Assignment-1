using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public bool isOpen = false;
    public bool requiresKey = true;
    public Vector3 openRotation = new Vector3(0, 90, 0); // Rotate 90 degrees on Y
    public float openSpeed = 2f;

    private Quaternion closedRotation;
    private Quaternion openedRotation;

    void Start()
    {
        closedRotation = transform.rotation;
        openedRotation = Quaternion.Euler(openRotation) * closedRotation;
    }

    public void Interact(PlayerBehaviour player)
    {
        if (requiresKey && !player.HasKey)
        {
            Debug.Log("Door is locked. Player needs a key.");
            return;
        }

        if (!isOpen)
        {
            Debug.Log("Door opening...");
            isOpen = true;
            transform.rotation = openedRotation;
            isOpen = true;
            
        }
    }


}
