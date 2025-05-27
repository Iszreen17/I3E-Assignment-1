using Unity.VisualScripting;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{   

    private int health = 5;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collided with {collision.gameObject.name}");

        if (collision.gameObject.CompareTag("Heal"))
        {   
           if (health < 10)
           {
              health +=1;
           }

            Debug.Log($"Health is {health}");
        }

       else if (collision.gameObject.CompareTag("Kill"))
       {
            if (health > 0) health -=1;
            {
                health -=1;
            }

            Debug.Log($"Health is {health}");

       }

    }

    void OnInteract()
    {
        Debug.Log("Interacting with object");
    }

    
}
