using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{

    [SerializeField]
    TMP_Text scoreUI;

    int score;

    public bool HasKey { get; set; } = false;


    void Update()
    {

    }


    // Player's maximum health
    int maxHealth = 100;
    // Player's current health
    int currentHealth = 50;
    // Player's current score
    int currentScore = 0;
    // Flag to check if the player can interact with objects
    bool canInteract = false;
    // Stores the current coin object the player has detected
    CoinBehaviour currentCoin = null;
    DoorBehaviour currentDoor = null;

    // The Interact callback for the Interact Input Action
    // This method is called when the player presses the interact button


    // Method to modify the player's score
    // This method takes an integer amount as a parameter
    // It adds the amount to the player's current score
    // The method is public so it can be accessed from other scripts
    public void ModifyScore(int amt)
    {
        // Increase currentScore by the amount passed as an argument
        currentScore += amt;
    }

    // Method to modify the player's health
    // This method takes an integer amount as a parameter
    // It adds the amount to the player's current health
    // The method is public so it can be accessed from other scripts
    public void ModifyHealth(int amount)
    {
        // Check if the current health is less than the maximum health
        // If it is, increase the current health by the amount passed as an argument
        if (currentHealth < maxHealth)
        {
            currentHealth += amount;
            // Check if the current health exceeds the maximum health
            // If it does, set the current health to the maximum health
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }
    }



    // Trigger Callback for when the player enters a trigger collider
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        // Check if the player detects a trigger collider tagged as "Collectible" or "Door"
        if (other.CompareTag("Collectible"))
        {
            // Set the canInteract flag to true
            // Get the CoinBehaviour component from the detected object
            canInteract = true;
            currentCoin = other.GetComponent<CoinBehaviour>();

            if (currentCoin != null)
            {
                //currentCoin.Highlight();
            }

        }
        else if (other.CompareTag("Door"))
        {
            canInteract = true;
            currentDoor = other.GetComponent<DoorBehaviour>();
        }
    }

    // Trigger Callback for when the player exits a trigger collider
    void OnTriggerExit(Collider other)
    {
        // Check if the player has a detected coin or door
        if (currentCoin != null)
        {
            // If the object that exited the trigger is the same as the current coin
            if (other.gameObject == currentCoin.gameObject)
            {
                // Set the canInteract flag to false
                // Set the current coin to null
                // This prevents the player from interacting with the coin
                //currentCoin.Unhighlight();
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
            //currentCoin.Collect(this);
            score++;
            scoreUI.text = $"{score}";
        }
        else if (currentDoor != null)
        {
            currentDoor.Interact(this); // Pass this player object to the door
        }
    }
}



    


}
