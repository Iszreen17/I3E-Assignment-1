using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int score;

    // [SerializeField]
    // private TMP_Text
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
            return;
        }

        instance = this; // Assign instance to the static variable
        DontDestroyOnLoad(this); // tell unity to not destroy this instance when load new scene
    }

    public void changeScore(int amount)

    {
        score += amount;
    }
    
}
