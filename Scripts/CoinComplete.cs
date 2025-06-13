using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinComplete : MonoBehaviour
{
    public GameObject congratsUI; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Congrats game is completed!");

            if (congratsUI != null)
            {
                congratsUI.SetActive(true); // Show Congrats screen
            }

            Destroy(gameObject); // Remove the happy coin from the scene
        }
    }
}