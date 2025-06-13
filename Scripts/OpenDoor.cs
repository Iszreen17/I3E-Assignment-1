using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animation hingehere; // tried to use another method for the MainDoor therefore, there's animation

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E)) // usage of the E key for thie main door 
        hingehere.Play();
    }
}
