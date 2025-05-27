using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputBehaviour : MonoBehaviour
{
    private int score;
    
    public void ModifyScore(int amount)
    {
        if (amount > 0 && score < 100)
        {
            score += amount;
        }
        else if(amount < 0 && score > 0)
        {
            score -= amount;
        }

        if(score > 100) score = 100;   
        if (score < 0) score = 0;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            collectable = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        
    }
}
