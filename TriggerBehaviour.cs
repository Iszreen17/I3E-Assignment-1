using Unity.VisualScripting;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
{   
    void OnInteract()
   {
     if 
   }

   void OnTriggerEnter (Collider other)
   {
     Debug.Log($"Entered is triggered! {other.name}");

     if (other.CompareTag("Collectable"))
     {
        Debug.Log("Touched & collectable item");
     }
   }

   
}
