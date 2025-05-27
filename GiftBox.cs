using Unity.VisualScripting;
using UnityEngine;

public class GiftBox : MonoBehaviour
{
    public GameObject coin;
    public GameObject explosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            Debug.Log("Gift box destroyed!");
            Destroy(this.gameObject);

            Destroy(Instantiate(explosion, transform.position, explosion.transform.rotation), 2f);

            var spawnCoin = Instantiate(coin, transform.position, coin.transform.rotation);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
        
}
