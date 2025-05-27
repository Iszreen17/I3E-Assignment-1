using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{    private int score;
    private GameObject collectible;

    public void ModifyScore(int amount)
    {
        score += amount;

        if (score > 100) score = 100;
        if (score < 0) score = 0;

        Debug.Log($"Score is {score}");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            collectible = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == collectible)
        {
            collectible = null;
        }
    }

    void OnInteract()
    {
        var coinBehaviour = collectible.GetComponent<CoinBehaviour>();
        coinBehaviour.Collect(this);
    }
}
