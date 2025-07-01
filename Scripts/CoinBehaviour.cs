using TMPro;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{

    public GameObject Congrats;
    public int totalCoins = 45;
    public static int collectedCoins = 0;


    public TextMeshProUGUI Score;


    //This function below is to ensure that the correct tag is being used to execute the collecting function.
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Collectible")
        {
            collectedCoins += 5;
            Score.text = "Score: " + collectedCoins.ToString();
            Destroy(other.gameObject);
            // GameManager.instance.changeScore(amount);
        }
    }

    // public void Collect(PlayerBehaviour player)
    // {
    //     GameManager.instance.changeScore(amount)
    // }
}
