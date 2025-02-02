using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Référence au texte UI pour le score
    private int score = 0;

    void Start()
    {
        score = 0;
        UpdateScoreUI();
    }

    void Update()
    {
        // Augmenter le score avec le temps
        score += Mathf.FloorToInt(Time.deltaTime * 10); // Ajustez le multiplicateur
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}
