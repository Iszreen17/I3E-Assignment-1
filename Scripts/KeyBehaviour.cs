using UnityEngine;
using TMPro;

public class KeyBehaviour : MonoBehaviour
{
    public Component doorcolliderhere;
    public GameObject Keygone;

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
            doorcolliderhere.GetComponent<BoxCollider>().enabled = true;
        
        if (Input.GetKey(KeyCode.E))
        Keygone.SetActive(false); // key to disappear after collecting
    }
}
