using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinDecoy : MonoBehaviour
{
    public GameObject gameOverUI; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Decoy coin collected. Game Over!");

            if (gameOverUI != null)
            {
                gameOverUI.SetActive(true); // Show Game Over screen
            }

            Destroy(gameObject); // Remove the decoy from the scene
        }
    }
}