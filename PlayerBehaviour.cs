using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{

    [SerializeField]
    TMP_Text scoreUI;

    int score;

    // this is to ensure that the player has collected the key, it is set to false as the initial stage, player does not have the key.
    public bool HasKey { get; set; } = false; 


    void Update()
    {

    }
    
    int currentScore = 0;
   
    bool canInteract = false;

    CoinBehaviour currentCoin = null;
    DoorBehaviour currentDoor = null;





    // This function below allows player to ensure that the correct tag is assigned correctly, so that the function can be executed. 
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        
        if (other.CompareTag("Collectible"))
        {
          
            canInteract = true;
            currentCoin = other.GetComponent<CoinBehaviour>();

            if (currentCoin != null)
            {
                
            }

        }
        else if (other.CompareTag("Door"))
        {
            canInteract = true;
            currentDoor = other.GetComponent<DoorBehaviour>();
        }
    }

    
    void OnTriggerExit(Collider other)
    {
        
        if (currentCoin != null)
        {
          
            if (other.gameObject == currentCoin.gameObject)
            {

                canInteract = false;
                currentCoin = null;
            }
        }
    }
    
   void OnInteract()
{
    if (canInteract)
    {
        if (currentCoin != null)
        {
            
            score++;
            scoreUI.text = $"{score}";
        }
        else if (currentDoor != null)
        {
            currentDoor.OnInteract(); // Pass this player object to the door
        }
    }
}



    


}
