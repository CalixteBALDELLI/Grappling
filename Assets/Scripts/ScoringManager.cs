using TMPro;
using UnityEngine;

public class ScoringManager : MonoBehaviour
{
    public int CurrentScore;
    
    private static ScoringManager instance = null;
    public static ScoringManager SINGLETON => instance;
    public float playerSpeed;
    public float currentPlayerRotationSpeed;
    public GameObject currentPlatform;


    public TextMeshProUGUI scoreText;
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
        }

    public void IncreaseScore(int amount)
    {
        CurrentScore += amount;
        scoreText.text = CurrentScore.ToString();
    }
}
