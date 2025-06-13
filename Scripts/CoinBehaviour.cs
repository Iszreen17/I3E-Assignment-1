using TMPro;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    private int Coin = 0;

    public TextMeshProUGUI Score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Collectible")
        {
            Coin++;
            Score.text = "Score: " + Coin.ToString();
            Destroy(other.gameObject);
        }
    }
}
